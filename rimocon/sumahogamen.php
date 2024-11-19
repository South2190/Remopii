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
	  .disabledbtn{
		margin-top: 4.5%;
        margin-right: 2.25%;
        margin-left: 2.25%;
        display: inline-block;
        width: 24%;
        padding: 5% 0;
        text-decoration: none;
        text-align: center;
        border-radius: 7px;
	    }
      
    </style>

  </head>
  
  
  <div class="btn">
    <form method="post"> 
      <?php
      $filename = "Button.json";

      $json_data = file_get_contents($filename);
      if ($json_data === false) {
        echo "Internal Server Error";
    }else{
  
      $arr = json_decode($json_data,true);

      $value = $arr[0]['mainBtn1'][0]['Value'];
      echo '<input type="submit" value=' . $value . ' name="mainBtn1"  class="mainbtn1"/>';
      $value = $arr[1]['mainBtn2'][0]['Value'];
      echo '<input type="submit" value=' . $value . ' name="mainBtn2" class="mainbtn2"/>';

      for($i = 1; $i <= 9; $i++){
        if($arr[$i + 1]['subBtn' . $i . ''][1]['Hidden'] == 1) { 
            $value = $arr[$i + 1]['subBtn' . $i . ''][0]['Value'];
            $btnclass = "subbtn";
            $btndisabled = "null";
          }else{
            $value = "無効";
            $btnclass = "disabledbtn";
            $btndisabled = "disabled";
          }
          echo '<input type="submit" value=' . $value . ' name="subBtn' . $i . '" ' . $btndisabled . '  class=' . $btnclass . ' />';
        }
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


