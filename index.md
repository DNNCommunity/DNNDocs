<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
<style type="text/css">
    body::after {
        content: "";
        display: block;
        position: fixed;
        z-index: -1;   
        width: 100%;
        height: 100%;
        background-image: url(images/hero-background-15.jpg?ver=2017-08-18-172107-023);
        background-size: cover;
        opacity: 0.1;
        top: 0;
        left: 0;
        bottom: 0;
        right: 0;
    }    
    .home .api-section {
        position: relative;
        margin-bottom: 30px;
    }
    .home .api-section > .wrapper {
        background: white;
        border: 1px solid #ebebeb;
        border-radius: 4px;
        box-shadow: 0 2px 6px rgba(0, 0,0,0.04);
        display: block;
        padding: 30px;
    }
    .home .api-section .icon { font-size: 5em; padding-right: 30px }
    .home .api-section .icon.administrators { color: #93A100; }
    .home .api-section .icon.content-editors { color: #1AB3CF; }
    .home .api-section .icon.developers { color: #9F58A9; }
    .home .api-section .icon.designers { color: #C9933F; }
    .home .api-section .icon.community-managers { color: #4A94DC; }
    .home .api-section .media-heading { color: #00a4e4; }
    .home .api-section .contributors {
        position: absolute;
        bottom: 4px;
        right: 4px;
    }
    .home .hero {
        margin-bottom: 50px;
        border-left: 6px solid #00a4e4;
        padding-left: 30px;
        background: rgba(255, 255, 255, .5);
        padding: 30px;
        box-shadow: 0 2px 6px rgba(0, 0,0,0.04);
        border-radius: 4px;
    }
    .home .hero h1 { margin-top: 0; color: #00a4e4; }
    .home .hero h2 {
        margin: 0;
        font-size: 1.5em;
        margin-bottom: 40px;
    }
    .home .hero p {}
    .home .api-section .media-left { vertical-align: middle; }
    .home .api-section .contributors img { width: 35px; height: 35px; border-radius: 50%; border: 3px solid white; background: white; }
    .home .api-section .contributors img:nth-child(n+2) { margin-left: -10px }
    .home .api-section .feature-block {}
    .home .api-section ul.popular-topics { margin-bottom: 20px; }
    .home .api-section ul.popular-topics li { display: inline-block; }
    .home .hero .feature-block img {
        max-width: 90px;
        max-height: 90px;
    }
    .home .hero .feature-block h3 { margin-top: 10px; }
    .home .hero .feature-block p {}
    .home .top-contributors {}
    .home .top-contributors li {}
    .home .top-contributors h6 {}
    .home .top-contributors .title { font-size: .7em; }
    .home .top-contributors img {
        width: 50px;
        height: 50px;
        max-width: inherit;
        border-radius: 50%;
        background: white;
        border: 1px solid #ebebeb;
    }
    .home.side-content {
        margin-bottom: 40px;
    }
    .home ul.popular-topics { padding-left: 0; }
    .home ul.popular-topics li { list-style-type: none;border-bottom: 1px solid #ebebeb;padding: 5px; }
    .home.ntn { margin-bottom: 50px; }
    .home.ntn h3 { color: #ee3a43; margin-bottom: 20px; }
    .home.ntn .ntn-block {
        padding: 10px;
        background: rgba(255, 255, 255, .4);
    }
    .home.ntn .ntn-block h4 {    
        margin: 0;
        padding-bottom: 5px;
        color: #00a4e4;
    }
    .home.ntn .ntn-block ul { padding-left: 0; margin-top: 10px; }
    .home.ntn .ntn-block ul li { list-style-type: none;}
</style>


<div class="row home">
    <div class="col-lg-12">
        <div class="hero">
            <h1 class="text-center">Welcome to the DNN Docs</h1>
            <h2 class="text-center"><em>documentation created for the community, by the community</h2>
            <div class="row feature-wrapper">
                <div class="col-md-4 feature-block text-center">
                    <img src="images/commOverview_joinppl.png">
                    <h3>DNN Platform</h3>
                    <p>
                        The leading .NET open source CMS &amp; App Dev Framework
                    </p>
                    <a href="http://dnnsoftware.org" target="_blank" class="btn btn-default">Learn More</a>
                </div>
                <div class="col-md-4 feature-block text-center">
                    <img src="images/communityDLSeal.png">
                    <h3>Open Source</h3>
                    <p>
                        Check out DNN Platform's open source code base on GitHub.
                    </p>
                    <a href="https://github.com/dnnsoftware/Dnn.Platform" target="_blank" class="btn btn-default">Learn More</a>
                </div>
                <div class="col-md-4 feature-block text-center">
                    <img src="images/DNN-Branded-Rocket.png">
                    <h3>Getting Started</h3>
                    <p>
                        Learn how you can get started with the DNN Docs!
                    </p>
                    <a class="btn btn-default">Learn More</a>
                </div>
            </div>            
        </div>
    </div>
    
</div>

<div class="row home ntn">
    <div class="col-sm-12 text-center">
        <h3>What you most need to know about DNN</h3>        
    </div>
    <div class="col-md-4">
        <div class="ntn-block">
            <h4>Get Started Quickly</h4>
            <ul>
                <li><a>How to install DNN</a></li>
                <li><a>Find hosting for DNN</a></li>
                <li><a>Something else</a></li>
            </ul>
        </div>
    </div>
    <div class="col-md-4">
        <div class="ntn-block">
            <h4>Audience Two</h4>
            <ul>
                <li><a>How to install DNN</a></li>
                <li><a>Find hosting for DNN</a></li>
                <li><a>Something else</a></li>
            </ul>
        </div>
    </div>
    <div class="col-md-4">
        <div class="ntn-block">
            <h4>Audience Three</h4>
            <ul>
                <li><a>How to install DNN</a></li>
                <li><a>Find hosting for DNN</a></li>
                <li><a>Something else</a></li>
            </ul>
        </div>
    </div>    
</div>   

<div class="row home">
    <div class="col-lg-12">
        <div class="api-section">
            <div href="/content/administrators" class="wrapper">
                <div class="media">
                    <div class="media-left">
                        <i class="fas fa-users-cog administrators icon"></i>
                    </div>
                    <div class="media-body">
                        <h2 class="media-heading">Administrators</h2>
                        <p>
                            Hello, Administrator! Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                             quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        </p>
                        <ul class="popular-topics">
                            <li style="border-bottom: 0;">Popular: </li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                        </ul>
                    </div>
                </div>
                <div class="contributors">
                    <img src="https://avatars0.githubusercontent.com/u/4571863?s=60&v=4">                    
                    <img src="https://avatars3.githubusercontent.com/u/4568451?s=60&v=4">                   
                    <img src="https://avatars3.githubusercontent.com/u/6237180?s=60&v=4">                    
                </div>
            </div>
        </div>
        <div class="api-section">
            <div class="wrapper">
                <div class="media">
                    <div class="media-left">
                        <i class="fas fa-signature content-editors icon"></i>
                    </div>
                    <div class="media-body">
                        <h2 class="media-heading">Content Editors</h2>
                        <p>
                            Hello, Content Manager! Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                             quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        </p>
                        <ul class="popular-topics">
                            <li style="border-bottom: 0;">Popular: </li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                        </ul>
                    </div>
                </div>
                <div class="contributors">
                    <img src="https://avatars3.githubusercontent.com/u/1757808?s=60&v=4">
                    <img src="https://avatars0.githubusercontent.com/u/4571863?s=60&v=4">                    
                    <img src="https://avatars3.githubusercontent.com/u/6603270?s=60&v=4"> 
                    <img src="https://avatars3.githubusercontent.com/u/4568451?s=60&v=4">                   
                    <img src="https://avatars2.githubusercontent.com/u/3319692?s=60&v=4">                    
                    <img src="https://avatars3.githubusercontent.com/u/6237180?s=60&v=4">                    
                </div>
            </div>
        </div>
        <div class="api-section">
            <div class="wrapper">
                <div class="media">
                    <div class="media-left">
                        <i class="fas fa-code developers icon"></i>
                    </div>
                    <div class="media-body">
                        <h2 class="media-heading">Developers</h2>
                        <p>
                            Hello, Developer! Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                             quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        </p>
                        <ul class="popular-topics">
                            <li style="border-bottom: 0;">Popular: </li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                        </ul>
                    </div>
                </div>
                <div class="contributors">
                    <img src="https://avatars3.githubusercontent.com/u/1757808?s=60&v=4">
                    <img src="https://avatars0.githubusercontent.com/u/4571863?s=60&v=4">                    
                    <img src="https://avatars3.githubusercontent.com/u/6603270?s=60&v=4"> 
                    <img src="https://avatars3.githubusercontent.com/u/4568451?s=60&v=4">                   
                    <img src="https://avatars2.githubusercontent.com/u/3319692?s=60&v=4">                                                         
                </div>
            </div>
        </div>
        <div class="api-section">
           <div class="wrapper">
                <div class="media">
                    <div class="media-left">
                        <i class="fas fa-fill-drip designers icon"></i>
                    </div>
                    <div class="media-body">
                        <h2 class="media-heading">Designers</h2>
                        <p>
                            Hello, Designer! Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                             quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        </p>
                        <ul class="popular-topics">
                            <li style="border-bottom: 0;">Popular: </li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                        </ul>
                    </div>
                </div>
                <div class="contributors">
                    <img src="https://avatars3.githubusercontent.com/u/4568451?s=60&v=4"> 
                    <img src="https://avatars0.githubusercontent.com/u/4571863?s=60&v=4">                    
                    <img src="https://avatars3.githubusercontent.com/u/6603270?s=60&v=4">                                                           
                </div>
            </div>
        </div>
        <div class="api-section">
            <div class="wrapper">
                <div class="media">
                    <div class="media-left">
                        <i class="fas fa-users community-managers icon"></i>
                    </div>
                    <div class="media-body">
                        <h2 class="media-heading">Community Managers</h2>
                        <p>
                            Hello, Community Manager! Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                             quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        </p>
                        <ul class="popular-topics">
                            <li style="border-bottom: 0;">Popular: </li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                            <li><a>Link to a popular topic</a></li>
                        </ul>
                    </div>
                </div>
                <div class="contributors">
                    <img src="https://avatars3.githubusercontent.com/u/4568451?s=60&v=4"> 
                    <img src="https://avatars0.githubusercontent.com/u/4571863?s=60&v=4">                    
                    <img src="https://avatars3.githubusercontent.com/u/6603270?s=60&v=4">                                                           
                </div>
            </div>
        </div>
    </div>
</div>

<div id="contrib-container" class="home side-content">
    <h4> <i class="fas fa-fire" style="color: #ee3a43"></i> Top Contributors</h4>    
    <hr/>
    <ul class="media-list top-contributors">
        <li class="media">
            <div class="media-left">
                <a href="#">
                    <img class="media-object" src="https://avatars0.githubusercontent.com/u/4571863?s=60&v=4">
                </a>
            </div>
            <div class="media-body">
                <h5 class="media-heading">Clint Patterson</h5>
                <span class="title">Ecosystem Manager at DNN</span>
            </div>
        </li>
        <li class="media">
            <div class="media-left">
                <a href="#">
                    <img class="media-object" src="https://avatars3.githubusercontent.com/u/1757808?s=60&v=4">
                </a>
            </div>
            <div class="media-body">
                <h5 class="media-heading">Kelly Ford</h5>
                <span class="title">Knowbetter Creative Services</span>
            </div>
        </li>
        <li class="media">
            <div class="media-left">
                <a href="#">
                    <img class="media-object" src="https://avatars3.githubusercontent.com/u/6603270?s=60&v=4">
                </a>
            </div>
            <div class="media-body">
                <h5 class="media-heading">Patrick Ryan</h5>
                <span class="title">Reflect Media Group LLC</span>
            </div>
        </li>
        <li class="media">
            <div class="media-left">
                <a href="#">
                    <img class="media-object" src="https://avatars3.githubusercontent.com/u/4568451?s=60&v=4">
                </a>
            </div>
            <div class="media-body">
                <h5 class="media-heading">David Poindexter</h5>
                <span class="title">nvisionative, Inc.</span>
            </div>
        </li>
        <li class="media">
            <div class="media-left">
                <a href="#">
                    <img class="media-object" src="https://avatars2.githubusercontent.com/u/3319692?s=60&v=4">
                </a>
            </div>
            <div class="media-body">
                <h5 class="media-heading">Peter Donker</h5>
                <span class="title">Bring2Mind</span>
            </div>
        </li>
        <li class="media">
            <div class="media-left">
                <a href="#">
                    <img class="media-object" src="https://avatars3.githubusercontent.com/u/6237180?s=60&v=4">
                </a>
            </div>
            <div class="media-body">
                <h5 class="media-heading">Fransisco Perez Andres</h5>
                <span class="title">DOTWARE</span>
            </div>
        </li>        
    </ul>
</div>

<div id="topic-container" class="home side-content">
    <h4> <i class="fas fa-bookmark" style="color: #00a4e4"></i> Popular Topics</h4>    
    <hr/>
    <ul class="popular-topics">
        <li>
           <a>Replace me</a>
        </li>
        <li>
           <a>Replace me</a>
        </li>
        <li>
           <a>Replace me</a>
        </li>
        <li>
           <a>Replace me</a>
        </li>
        <li>
           <a>Replace me</a>
        </li>
        <li>
           <a>Replace me</a>
        </li>
        <li>
           <a>Replace me</a>
        </li>
        <li>
           <a>Replace me</a>
        </li>
        <li>
           <a>Replace me</a>
        </li>
        <li>
           <a>Replace me</a>
        </li>              
    </ul>
</div>

<script>
    (function() {
        document.addEventListener('DOMContentLoaded', function () {
            var sidebars = document.getElementsByClassName("sideaffix");
            sidebars[0].parentNode.removeChild(sidebars[0]);
            var contribs = document.getElementById('contrib-container');
            var topics = document.getElementById('topic-container');
            var content = document.getElementById('_content');
            content.parentNode.nextElementSibling.append(contribs); 
            content.parentNode.nextElementSibling.append(topics);        
        });        
    }());
</script>


