<?php
session_start();
$dir_nav =  ($_SERVER['DOCUMENT_ROOT'].'/streamingHTML/'); //default server path
$data = null;
if(isset($_GET['user']) && $_GET['user'] != null){
    $guid = $_GET['user'];
    $data = json_decode(file_get_contents('http://31.15.224.24:53851/api/users/getuser?guid='.$_SESSION['guid']),true);
    /*if($data != null){
        print_r(var_dump($data));
    }*/
}
?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta http-equiv="Content-Type" content="text/html;charset=UTF-8" />
        <title><?php ?></title>
        <link rel="stylesheet" type="text/css" href="../css/style.css"/>
        <script
  src="https://code.jquery.com/jquery-3.1.1.min.js"
  integrity="sha256-hVVnYaiADRTO2PzUGmuLJr8BLUSjGIZsDYGmIJLv2b8="
  crossorigin="anonymous"></script>
    </head>
    <body>
        <div class="hamburger" id="hamburger" onclick="toggleSidenav();">
          <div></div>
          <div></div>
          <div></div>
        </div>
        <!-- Sidebar -->
        <?php include $dir_nav.'website/navigation_left.php'; ?>
        <!-- /#sidebar-wrapper -->
        <!-- Page Content -->
        <div class="main">
            <?php 
                if(isset($data) && $data != null){
                    $display_name = $data["user_display_name"];
                    $img = $data["profile_image"];
                    echo "<div class='user_profile'>
                            <div class='profile_picture'>
                                <img alt='".$display_name."_picture' src='data:image/jpeg;base64, $img' />
                                <form action='../upload.php?avatar=upload' method='post' enctype='multipart/form-data'>
                                    Select image to upload:
                                    <input type='file' name='avatar' id='avatar'>
                                    <input type='submit' value='Upload Image' name='submit'>
                                </form>";
                                
                    if(isset($_SESSION['post_message'])){
                        echo $_SESSION['post_message'];
                        $_SESSION['post_message'] = "";
                    }
                                    
                    echo "</div></div>";
                }
            ?>
        </div>
        <!-- /#page-content-wrapper -->
        <script type="application/javascript">
            function toggleSidenav() {
              document.body.classList.toggle('sidenav-active');
            }
        </script>
    </body>
</html>