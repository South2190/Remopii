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
      <input type="submit" value="戻る" name="btn1" class="btn1"/>
      <input type="submit" value="進む" name="btn2" class="btn2"/>

      <input type="submit" value="あ" name="btn3" class="subbtn"/>
      <input type="submit" value="い" name="btn4" class="subbtn"/>
      <input type="submit" value="う" name="btn5" class="subbtn"/>

      <input type="submit" value="え" name="btn6" class="subbtn"/>
      <input type="submit" value="お" name="btn7" class="subbtn"/>
      <input type="submit" value="か" name="btn8" class="subbtn"/>

      <input type="submit" value="き" name="btn9" class="subbtn"/>
      <input type="submit" value="く" name="btn10" class="subbtn"/>
      <input type="submit" value="け" name="btn11" class="subbtn"/>

    </form>
  </div>
</html>
