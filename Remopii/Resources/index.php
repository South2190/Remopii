<?php
    //ボタン押したときの処理
    if(array_key_exists('mainBtn1', $_POST)) { 
        exec('schtasks /run /tn Remopii\MainButton1');
        header("Location:{$_SERVER['PHP_SELF']}");
        exit;
    }
    if(array_key_exists('mainBtn2', $_POST)) {  
        exec('schtasks /run /tn Remopii\MainButton2'); 
        header("Location:{$_SERVER['PHP_SELF']}");
        exit;
    }
    if(array_key_exists('subBtn1', $_POST)) {  
        exec('schtasks /run /tn Remopii\SubButton1');
        header("Location:{$_SERVER['PHP_SELF']}");
        exit;
    }
    if(array_key_exists('subBtn2', $_POST)) { 
        exec('schtasks /run /tn Remopii\SubButton2');
        header("Location:{$_SERVER['PHP_SELF']}");
        exit;
    }
    if(array_key_exists('subBtn3', $_POST)) { 
        exec('schtasks /run /tn Remopii\SubButton3');
        header("Location:{$_SERVER['PHP_SELF']}");
        exit;
    }
    if(array_key_exists('subBtn4', $_POST)) { 
        exec('schtasks /run /tn Remopii\SubButton4');
        header("Location:{$_SERVER['PHP_SELF']}");
        exit;
    }
    if(array_key_exists('subBtn5', $_POST)) { 
        exec('schtasks /run /tn Remopii\SubButton5');
        header("Location:{$_SERVER['PHP_SELF']}");
        exit;
    }
    if(array_key_exists('subBtn6', $_POST)) { 
        exec('schtasks /run /tn Remopii\SubButton6');
        header("Location:{$_SERVER['PHP_SELF']}");
        exit;
    }
    if(array_key_exists('subBtn7', $_POST)) { 
        exec('schtasks /run /tn Remopii\SubButton7');
        header("Location:{$_SERVER['PHP_SELF']}");
        exit;
    }
    if(array_key_exists('subBtn8', $_POST)) { 
        exec('schtasks /run /tn Remopii\SubButton8');
        header("Location:{$_SERVER['PHP_SELF']}");
        exit;
    }
    if(array_key_exists('subBtn9', $_POST)) { 
        exec('schtasks /run /tn Remopii\SubButton9');
        header("Location:{$_SERVER['PHP_SELF']}");
        exit;
    }
?>
<!DOCTYPE html>
<html lang="ja">
    <head>
        <meta name="viewport" content="width=device-width,initial-scale=1.0">
        <meta charset="utf-8">
        <title>リモピー</title>
        <style>
            /*ダークモード対応*/
            @media (prefers-color-scheme: dark) {
                body {
                    background-color: #000;
                }
            }
            /*ボタンのサイズ等の設定*/
            body{
                max-width: 480px;
                margin: auto;
            }
            input{
                aspect-ratio: 1;
                min-height: 80px;
                border-radius: 7px;
                text-wrap: wrap;
                overflow-wrap: break-word;
                vertical-align: top;
            }
            .mainbtn1 {
                margin: 2.5%;
                width: 45%;
                max-height: min(45vw,216px);
                font-size: min(9vw,300%);
                color: #000;
                background-color: #63bbde;
                box-shadow: 2px 2px #777777;
                line-height: normal;
            }
            .mainbtn1:active{
                background: #325f70;
                color: #FFF;
            }
            .mainbtn2 {
                margin: 2.5%;
                width: 45%;
                max-height: min(45vw,216px);
                font-size: min(9vw,300%);
                color: #000;
                background-color: #6cc786;
                box-shadow: 2px 2px #777777;
            }
            .mainbtn2:active{
                background: #335e3f;
                color: #FFF;
            }
            .subbtn{
                margin: 2.25%;
                width: 28.5%;
                max-height: min(28.5vw,136.8px);
                font-size: min(6.25vw,200%);
                color: #000;
                background-color: #bfcec3;
                box-shadow: 2px 2px #777777;
            }
            .subbtn:active{
                background: #7b867e;
                color: #FFF;
            }
	        .disabledbtn{
                margin: 2.25%;
                width: 28.5%;
                font-size: min(6.25vw,200%);
                border-radius: 7px;
	        }
        </style>
    </head>
    <body>
        <form method="post">
            <?php
                $fp = fopen("Button.csv", "r");
                for($i = 1; $i <= 11; $i++){
                    $data = fgetcsv($fp);
                    //メインボタンの表示
                    if($i<=2){
                        echo '<input type="submit" value="' . $data[0] . '" name="mainBtn' . $i . '"  class="mainbtn' . $i . '"/>';
                    }
                    //サブボタン（有効）の表示
                    elseif($data[1] == "True"){
                        echo '<input type="submit" value=' . $data[0] . ' name="subBtn' . $i-2 . '" class="subbtn" />';
                    }
                    //サブボタン（無効）の表示
                    else{
                        echo '<input type="submit" value="無効" name="subBtn' . $i-2 . '" disabled class="disabledbtn" />';
                    }
                }
                fclose($fp);
            ?>
        </form>
    </body>
</html>