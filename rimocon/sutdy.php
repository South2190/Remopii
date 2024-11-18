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

      .btn1 {
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
      .btn1:active{
      background: #325f70;
      color: #FFF;
      }

      .btn2 {
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
      .btn2:active{
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
      <input type="submit" value="戻る" name="mainbtn1" class="btn1"/>
      <input type="submit" value="進む" name="mainbtn2" class="btn2"/>

      <input type="submit" value="あ" name="subbtn1" class="subbtn"/>
      <input type="submit" value="い" name="subbtn2" class="subbtn"/>
      <input type="submit" value="う" name="subbtn3" class="subbtn"/>

      <input type="submit" value="え" name="subbtn4" class="subbtn"/>
      <input type="submit" value="お" name="subbtn5" class="subbtn"/>
      <input type="submit" value="か" name="subbtn6" class="subbtn"/>

      <input type="submit" value="き" name="subbtn7" class="subbtn"/>
      <input type="submit" value="く" name="subbtn8" class="subbtn"/>
      <input type="submit" value="け" name="subbtn9" class="subbtn"/>

    </form>
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
  </div>
</html>


