using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC_of_Computer.Classes
{
    public static class HttpClientProgressExtensions
    {
        public static async Task DownloadDataAsync(this HttpClient client, string requestUrl, Stream destination, IProgress<float> progress = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("サーバーへのアクセスに失敗しました。\nHTTPステータスコード: " + (int)response.StatusCode + " " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    long? contentLength = response.Content.Headers.ContentLength;
                    using (Stream download = await response.Content.ReadAsStreamAsync())
                    {
                        // no progress... no contentLength... very sad
                        if (progress is null || !contentLength.HasValue)
                        {
                            await download.CopyToAsync(destination);
                            return;
                        }
                        // Such progress and contentLength much reporting Wow!
                        Progress<long> progressWrapper = new(totalBytes => progress.Report(GetProgressPercentage(totalBytes, contentLength.Value)));
                        await download.CopyToAsync(destination, 81920, progressWrapper, cancellationToken);
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            float GetProgressPercentage(float totalBytes, float currentBytes) => (totalBytes / currentBytes) * 100f;
        }

        static async Task CopyToAsync(this Stream source, Stream destination, int bufferSize, IProgress<long> progress = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (bufferSize < 0)
                throw new ArgumentOutOfRangeException(nameof(bufferSize));
            if (source is null)
                throw new ArgumentNullException(nameof(source));
            if (!source.CanRead)
                throw new InvalidOperationException($"'{nameof(source)}' is not readable.");
            if (destination == null)
                throw new ArgumentNullException(nameof(destination));
            if (!destination.CanWrite)
                throw new InvalidOperationException($"'{nameof(destination)}' is not writable.");

            var buffer = new byte[bufferSize];
            long totalBytesRead = 0;
            int bytesRead;
            while ((bytesRead = await source.ReadAsync(buffer, 0, buffer.Length, cancellationToken).ConfigureAwait(false)) != 0)
            {
                await destination.WriteAsync(buffer, 0, bytesRead, cancellationToken).ConfigureAwait(false);
                totalBytesRead += bytesRead;
                progress?.Report(totalBytesRead);
            }
        }
    }
}
