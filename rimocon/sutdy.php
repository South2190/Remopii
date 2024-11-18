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

      $value = $arr[0]['mainBtn1'][0]['Value'];
      echo '<input type="submit" value=' . $value . ' name="mainBtn1" class="mainbtn1"/>';
      $value = $arr[1]['mainBtn2'][0]['Value'];
      echo '<input type="submit" value=' . $value . ' name="mainBtn2" class="mainbtn2"/>';

      $value = $arr[2]['subBtn1'][0]['Value'];
      if($arr[2]['subBtn1'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subBtn1" class="subbtn"/>';
      }
      $value = $arr[3]['subBtn2'][0]['Value'];
      if($arr[3]['subBtn2'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subBtn2" class="subbtn"/>';
      }
      $value = $arr[4]['subBtn3'][0]['Value'];
      if($arr[4]['subBtn3'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subBtn3" class="subbtn"/>';
      }

      $value = $arr[5]['subBtn4'][0]['Value'];
      if($arr[5]['subBtn4'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subBtn4" class="subbtn"/>';
      }
      $value = $arr[6]['subBtn5'][0]['Value'];
      if($arr[6]['subBtn5'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subBtn5" class="subbtn"/>';
      }
      $value = $arr[7]['subBtn6'][0]['Value'];
      if($arr[7]['subBtn6'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subBtn6" class="subbtn"/>';
      }

      $value = $arr[8]['subBtn7'][0]['Value'];
      if($arr[8]['subBtn7'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subBtn7" class="subbtn"/>';
      }
      $value = $arr[9]['subBtn8'][0]['Value'];
      if($arr[9]['subBtn8'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subBtn8" class="subbtn"/>';
      }
      $value = $arr[10]['subBtn9'][0]['Value'];
      if($arr[10]['subBtn9'][1]['Hidden'] == 1) { 
      echo '<input type="submit" value=' . $value . ' name="subBtn9" class="subbtn"/>';
      }
      
      ?>
    </form>
  </div>

  <?php
  if(array_key_exists('mainBtn1', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP'); 
  }
  
  if(array_key_exists('mainBtn2', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP'); 
  }

  if(array_key_exists('subBtn1', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subBtn2', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subBtn3', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subBtn4', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subBtn5', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subBtn6', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subBtn7', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subBtn8', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  if(array_key_exists('subBtn9', $_POST)) { 
    exec('schtasks /run /tn RunExeFromPHP');
  }

  ?>
</html>


