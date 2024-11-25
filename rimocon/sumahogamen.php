<?php
        if(array_key_exists('mainBtn1', $_POST)) { 
          exec('schtasks /run /tn RC_of_Computer\MainButton1');
          header("Location:{$_SERVER['PHP_SELF']}");
          exit;
        }
        
        if(array_key_exists('mainBtn2', $_POST)) {  
          exec('schtasks /run /tn RC_of_Computer\MainButton2'); 
          header("Location:{$_SERVER['PHP_SELF']}");
          exit;
        }
    
        if(array_key_exists('subBtn1', $_POST)) {  
          exec('schtasks /run /tn RC_of_Computer\SubButton1');
          header("Location:{$_SERVER['PHP_SELF']}");
          exit;
        }
      
        if(array_key_exists('subBtn2', $_POST)) { 
          exec('schtasks /run /tn RC_of_Computer\SubButton2');
          header("Location:{$_SERVER['PHP_SELF']}");
          exit;
         }
      
        if(array_key_exists('subBtn3', $_POST)) { 
          exec('schtasks /run /tn RC_of_Computer\SubButton3');
          header("Location:{$_SERVER['PHP_SELF']}");
          exit;
        }
      
        if(array_key_exists('subBtn4', $_POST)) { 
          exec('schtasks /run /tn RC_of_Computer\SubButton4');
          header("Location:{$_SERVER['PHP_SELF']}");
          exit;
        }
      
        if(array_key_exists('subBtn5', $_POST)) { 
          exec('schtasks /run /tn RC_of_Computer\SubButton5');
          header("Location:{$_SERVER['PHP_SELF']}");
          exit;
        }
      
        if(array_key_exists('subBtn6', $_POST)) { 
          exec('schtasks /run /tn RC_of_Computer\SubButton6');
          header("Location:{$_SERVER['PHP_SELF']}");
          exit;
        }
      
        if(array_key_exists('subBtn7', $_POST)) { 
           exec('schtasks /run /tn RC_of_Computer\SubButton7');
           header("Location:{$_SERVER['PHP_SELF']}");
          exit;
        }
      
        if(array_key_exists('subBtn8', $_POST)) { 
          exec('schtasks /run /tn RC_of_Computer\SubButton8');
          header("Location:{$_SERVER['PHP_SELF']}");
          exit;
        }
      
        if(array_key_exists('subBtn9', $_POST)) { 
          exec('schtasks /run /tn RC_of_Computer\SubButton9');
          header("Location:{$_SERVER['PHP_SELF']}");
          exit;
        }
    ?>
<!DOCTYPE html>
<html lang="ja">
  <head>
    <meta name="viewport" content="width=device-width,initial-scale=1.0">
    <meta charset="utf-8">
    <title>リモコン</title>

    <style>
      body{
        max-width: 480px;
        margin: auto;
      }
      .btn{
        height: 100%;
        text-align: center;
      }

      .mainbtn1 {
        margin-right: 3%;
        margin-top: 3.5%;
        margin-bottom: 5.5%; 
        display: inline-block;
        width: 46%;
        height: 200px;
        text-decoration: none;
        text-align: center;
        font-size: 400%;
        color: #000;
        background-color: #63bbde;
        border-radius: 7px;
        box-shadow: 2px 2px #777777;
      }
      .mainbtn1:active{
      background: #325f70;
      color: #FFF;
      }

      .mainbtn2 {
        margin-top: 3.5%;
        margin-bottom: 5.5%;
        display: inline-block;
        width: 46%;
        height: 200px;
        text-decoration: none;
        text-align: center;
        font-size: 400%;
        
        color: #000;
        background-color: #6cc786;
        border-radius: 7px;
        box-shadow: 2px 2px #777777;
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
        width: 28.5%;
        height: 120px;
        text-decoration: none;
        text-align: center;
        font-size: 200%;
        color: #000;
        background-color: #bfcec3;
        border-radius: 7px;
        box-shadow: 2px 2px #777777;
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
        width: 28.5%;
        height: 120px;
        text-decoration: none;
        text-align: center;
        font-size: 200%;
        border-radius: 7px;
	    }
      
    </style>

  </head>
  
  <body>
    <form method="post">
      <div class="btn">
        <?php
        $fp = fopen("Button.csv", "r");

        for($i = 1; $i <= 11; $i++){
          $data = fgetcsv($fp);
          //メインボタン
          if($i<=2){
            echo '<input type="submit" value="' . $data[0] . '" name="mainBtn' . $i . '"  class="mainbtn' . $i . '"/>';
          }
          //サブボタン（有効）
          elseif($data[1] == 1){
            echo '<input type="submit" value=' . $data[0] . ' name="subBtn' . $i-2 . '" class="subbtn" />';
          }
          //サブボタン（無効）
          else{
            echo '<input type="submit" value="無効" name="subBtn' . $i-2 . '" disabled class="disabledbtn" />';
          }
        }
        fclose($fp);
        ?>
      </div>
    </fofm>
  </body>
</html>
