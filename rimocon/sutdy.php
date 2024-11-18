<!DOCTYPE html>
<html lang="ja">
  <head>
    <meta name="viewport" content="width=device-width,initial-scale=1.0">
    <meta charset="utf-8">
    <title>test</title>
   
    <style>
      .btn{
        text-align: center;
      }

      .mainbtn1 {
        margin-right: 3%;
        margin-bottom: 5.5%; 
        display: inline-block;
        width: 40%;
        padding: 13% 0;
        text-decoration: none;
        text-align: center;
        color: #000;
        background-color: #63bbde;
        border-radius: 7px;
        box-shadow: 2px 2px gray;
        
      }
      .mainbtn1:active{
      background: #325f70;
      color: #FFF;
      }

      .mainbtn2 {
        margin-bottom: 5.5%;
        display: inline-block;
        width: 40%;
        padding: 13% 0;
        text-decoration: none;
        text-align: center;
        color: #000;
        background-color: #6cc786;
        border-radius: 7px;
        box-shadow: 2px 2px gray;
        
      }
      .mainbtn2:active{
      background: #335e3f;
      color: #FFF;
      }

      .subbtn{
        margin-top: 4.5%;
        margin-right: 2.25%;
        margin-left: 2.25%;
        display: inline-block;
        width: 24%;
        padding: 5% 0;
        text-decoration: none;
        text-align: center;
        color: #000;
        background-color: #bfcec3;
        border-radius: 7px;
        box-shadow: 2px 2px gray;
      }
      .subbtn:active{
      background: #7b867e;
      color: #FFF;
      }
      
    </style>

  </head>
  
  
  <div class="btn">
    <form method="post"> 
      <?php
      $filename = "Button.json";

      $json_data = file_get_contents($filename);
  
      $arr = json_decode($json_data,true);

      $value = $arr[0]['mainbtn1'][0]['value'];
      echo '<input type="submit" value=' . $value . ' name="mainbtn1" class="mainbtn1"/>';
      $value = $arr[1]['mainbtn2'][0]['value'];
      echo '<input type="submit" value=' . $value . ' name="mainbtn2" class="mainbtn2"/>';

      $value = $arr[2]['subbtn1'][0]['value'];
      if($arr[2]['subbtn1'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subbtn1" class="subbtn"/>';
      }
      $value = $arr[3]['subbtn2'][0]['value'];
      if($arr[3]['subbtn2'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subbtn2" class="subbtn"/>';
      }
      $value = $arr[4]['subbtn3'][0]['value'];
      if($arr[4]['subbtn3'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subbtn3" class="subbtn"/>';
      }

      $value = $arr[5]['subbtn4'][0]['value'];
      if($arr[5]['subbtn4'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subbtn4" class="subbtn"/>';
      }
      $value = $arr[6]['subbtn5'][0]['value'];
      if($arr[6]['subbtn5'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subbtn5" class="subbtn"/>';
      }
      $value = $arr[7]['subbtn6'][0]['value'];
      if($arr[7]['subbtn6'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subbtn6" class="subbtn"/>';
      }

      $value = $arr[8]['subbtn7'][0]['value'];
      if($arr[8]['subbtn7'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subbtn7" class="subbtn"/>';
      }
      $value = $arr[9]['subbtn8'][0]['value'];
      if($arr[9]['subbtn8'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subbtn8" class="subbtn"/>';
      }
      $value = $arr[10]['subbtn9'][0]['value'];
      if($arr[10]['subbtn9'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subbtn9" class="subbtn"/>';
      }
      
      ?>
    </form>
  </div>

  <?php
  if(array_key_exists('mainbtn1', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP'); 
  }
  
  if(array_key_exists('mainbtn2', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP'); 
  }

  if(array_key_exists('subbtn1', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subbtn2', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subbtn3', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subbtn4', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subbtn5', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subbtn6', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subbtn7', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subbtn8', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subbtn9', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  ?>
</html>


