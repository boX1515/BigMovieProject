<?php
session_start();
$dir_nav =  ($_SERVER['DOCUMENT_ROOT'].'/streamingHTML/');

$_SESSION['guid'] = "3fbddcc4-a446-4e5b-9d27-a8c118009ced";
if(isset($_POST['user'])){
    
}

?>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta http-equiv="Content-Type" content="text/html;charset=UTF-8" />
        <title>Movies</title>
        <link rel="stylesheet" type="text/css" href="../css/style.css"/>
        <script
  src="https://code.jquery.com/jquery-3.1.1.min.js"
  integrity="sha256-hVVnYaiADRTO2PzUGmuLJr8BLUSjGIZsDYGmIJLv2b8="
  crossorigin="anonymous"></script>
    </head>
    <body>
        <div id="wrapper">
            <!-- Sidebar -->
            <?php include $dir_nav.'website/navigation_left.php'; ?>
            <!-- /#sidebar-wrapper -->
            <!-- Page Content -->
            <div class="movielist">
                <?php 
                $data = json_decode(file_get_contents('http://31.15.224.24:53851/api/video/allmovies'),true);
                    for($i = 0; $i < count($data); $i++){
                    echo "<div class='movie' onClick='movie(this);'>
                           
                            <div class='poster'>
                                <img alt='poster' src='https://image.tmdb.org/t/p/w300/".$data[$i]["MovieInfo"]["poster_path"]."' width='120'/>
                                <div class='gradient'></div>
                            </div>
                            <div class='movie_data'>
                                <div class='id' style='display:none'>".$data[$i]["movie_guid"]."</div>
                                <div class='title'>
                                    <p>".$data[$i]["MovieInfo"]["title"]."</p>
                                    <p>".$data[$i]["MovieInfo"]["tagline"]."</p>
                                    <p>Release date: ".$data[$i]["MovieInfo"]["release_date"]."</p>
                                </div>
                            </div>
                        </div>";
                    }
                ?>
            </div>
            <!-- /#page-content-wrapper -->
        </div>
        <script type="application/javascript">
            function movie(x){
               var text = $(x).children(".movie_data").children(".id")[0].innerHTML;
                window.location.href = "../play/index.php?id="+text;
                console.log(text);
            }
        </script>
    </body>
</html>