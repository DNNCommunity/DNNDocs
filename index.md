<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
<style type="text/css">
    body.homepage::after {
        content: "";
        display: block;
        position: fixed;
        z-index: -1;   
        width: 100%;
        height: 100%;
        background-image: url(images/hero-background-15.jpg);
        background-size: cover;
        opacity: 0.1;
        top: 0;
        left: 0;
        bottom: 0;
        right: 0;
    }
    .homepage .hlead {
        border-bottom: 1px solid #00a4e44d;
        padding-bottom: 10px;
        margin-bottom: 15px;
        position: relative;
    }
    .homepage .hlead:before {
        content: '';
        position: absolute;
        left: 0;
        bottom: -1px;
        width: 42px;
        border-bottom: 1px solid #00a4e4;
    }
    /* Hide anchors on headings */
    .homepage .anchorjs-link { display: none; }     
    .homepage .api-section {
        position: relative;
        margin-bottom: 30px;
    }
    .homepage .api-section > .wrapper {
        background: white;
        border: 1px solid #ebebeb;
        border-radius: 4px;
        box-shadow: 0 2px 6px rgba(0, 0,0,0.04);
        padding: 30px;
    }
    .homepage .api-section .icon { font-size: 5em; padding-right: 30px }
    .homepage .api-section .icon.sm { font-size: inherit; padding-right: 5px; }
    .homepage .api-section .icon.administrators { color: #93A100; }
    .homepage .api-section .icon.content-editors { color: #1AB3CF; }
    .homepage .api-section .icon.developers { color: #9F58A9; }
    .homepage .api-section .icon.designers { color: #C9933F; }
    .homepage .api-section .icon.community-managers { color: #4A94DC; }
    .homepage .api-section .media-heading { color: #00a4e4; }
    .homepage .api-section .contributors {
        position: absolute;
        bottom: 4px;
        right: 4px;
    }
    .homepage .hero {
        margin-bottom: 50px;
        border-left: 6px solid #00a4e4;
        padding-left: 30px;
        background: rgba(255, 255, 255, .5);
        padding: 30px;
        box-shadow: 0 2px 6px rgba(0, 0,0,0.04);
        border-radius: 4px;
    }
    .homepage .hero ul { padding: 0; }
    .homepage .hero ul li { list-style-type: none; }
    .homepage .hero ul li a {}
    .homepage .hero h1 { margin-top: 0; }
    .homepage .hero h2 {
        margin: 0;
        font-size: 1.2em;
        margin-bottom: 40px;
    }
    .homepage .api-section .media-left { vertical-align: middle; }
    .homepage .api-section .contributors img { width: 35px; height: 35px; border-radius: 50%; border: 3px solid white; background: white; }
    .homepage .api-section .contributors img:nth-child(n+2) { margin-left: -10px }
    .homepage .api-section .feature-block {}
    .homepage .api-section ul.popular-topics { margin-bottom: 20px; }
    .homepage .api-section ul.popular-topics li { display: inline-block; }
    .homepage .hero .feature-block img {
        max-width: 90%;        
    }
    .homepage .hero .feature-block h3 { margin-top: 10px; }
    .homepage .hero .feature-block p {}
    .homepage .top-contributors {}
    .homepage .top-contributors li {}
    .homepage .top-contributors h6 {}
    .homepage .top-contributors .title { font-size: .7em; }
    .homepage .top-contributors img {
        width: 50px;
        height: 50px;
        max-width: inherit;
        border-radius: 50%;
        background: white;
        border: 1px solid #ebebeb;
    }
    .homepage .side-content {
        margin-bottom: 40px;
    }
    .homepage ul.popular-topics { padding-left: 0; margin-bottom: 25px; }
    .homepage ul.popular-topics li { list-style-type: none;border-bottom: 1px solid #ebebeb;padding: 5px; }
    .homepage .ntn { margin-bottom: 50px; }
    .homepage .ntn .ntn-block ul { padding-left: 0; margin-top: 10px; }
    .homepage .ntn .ntn-block ul li { list-style-type: none;}
    .homepage ul.events-list {padding-left: 0;}
    .homepage ul.events-list li { list-style-type: none; margin-bottom: 20px; }
    .homepage ul.events-list li .details { display: block; }
    @media only screen and (max-width : 480px) {
        .homepage .api-section .media-heading {
            font-size: 1.5em;
        }
    }
</style>


<div class="row home">
    <div class="col-lg-12">
        <div class="hero">
            <div class="row feature-wrapper">
                <div class="col-sm-4 feature-block text-center hidden-xs hidden-sm">
                    <img src="images/communityDLSeal.png">                    
                </div>
                <div class="col-md-8 col-sm-12 feature-block text-center">
                    <h1 class="text-center"><span class="hidden-xs">Welcome to the </span>DNN Docs</h1>
                    <h2 class="text-center"><em>documentation created for the community, by the community</h2>
                    <div class="row text-left">
                        <div class="col-sm-4">
                            <h4 class="hlead">Get Started</h4>
                            <ul>
                                <li><a href="/content/administrators/dnn-overview/index.html">What is DNN?</a></li>
                                <li><a>Install/Upgrade</a></li>
                                <li><a>Version History</a></li>
                            </ul>  
                        </div>
                        <div class="col-sm-4">
                            <h4 class="hlead">Extend DNN</h4>
                            <ul>
                                <li><a>Creating Themes</a></li>
                                <li><a>Creating Extensions</a></li>
                                <li><a>DNN API</a></li>                                
                            </ul>  
                        </div>
                        <div class="col-sm-4">
                            <h4 class="hlead">Get Involved</h4>
                            <ul>
                                <li><a>Contribute to DNN</a></li>
                                <li><a>Contribute to the Docs</a></li>
                            </ul>  
                        </div>
                    </div>
                </div>                
            </div>            
        </div>
    </div>    
</div>

<div class="row home">
    <div class="col-lg-12">
        <div class="search well well">
            <label for="homesearch" class="sr-only">Search the docs</label>
            <input id="homesearch" class="form-control" placeholder="Search the docs...">
        </div>
    </div>
</div>

<div class="row home">
    <div class="col-lg-12">
        <h2 class="hlead">Explore the Docs</h2>
    </div>
</div>

<!-- <div class="row home ntn">
    <div class="col-sm-4">
        <div class="ntn-block">
            <h4 class="hlead">Get Started Quickly</h4>
            <ul>
                <li><a>How to install DNN</a></li>
                <li><a>Find hosting for DNN</a></li>
                <li><a>Something else</a></li>
            </ul>
        </div>
    </div>
    <div class="col-sm-4">
        <div class="ntn-block">
            <h4 class="hlead">Audience Two</h4>
            <ul>
                <li><a>How to install DNN</a></li>
                <li><a>Find hosting for DNN</a></li>
                <li><a>Something else</a></li>
            </ul>
        </div>
    </div>
    <div class="col-sm-4">
        <div class="ntn-block">
            <h4 class="hlead">Audience Three</h4>
            <ul>
                <li><a>How to install DNN</a></li>
                <li><a>Find hosting for DNN</a></li>
                <li><a>Something else</a></li>
            </ul>
        </div>
    </div>    
</div>    -->

<div class="row home">
    <div class="col-lg-12">
        <div class="api-section">
            <div class="wrapper">
                <div class="media">
                    <div class="media-left hidden-xs">
                        <i class="fas fa-users-cog administrators icon"></i>
                    </div>
                    <div class="media-body">
                        <a href="/content/administrators/"><h2 class="media-heading"><i class="fas fa-users-cog administrators icon sm visible-xs-inline"></i>Administrators</h2></a>
                        <p>
                            Hello, Administrator! Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                             quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        </p>
                        <ul class="popular-topics">
                            <li style="border-bottom: 0;">Quick Links: </li>
                            <li><a href="/content/administrators">Home</a></li>
                            <li><a href="/content/administrators/setup/administrators-setup-overview/index.html">Setting Up DNN</a></li>
                            <li><a href="/content/administrators/configuring-your-site/administrators-configuring-your-site-overview/index.html">Configuring Your Site</a></li>
                            <li><a href="/content/administrators/troubleshooting/administrators-troubleshooting-overview/index.html">Troubleshooting</a></li>
                        </ul>
                    </div>
                </div>
                <div class="contributors hidden-xs">
                    <img src="https://avatars0.githubusercontent.com/u/4571863?s=60&v=4">                    
                    <img src="https://avatars3.githubusercontent.com/u/4568451?s=60&v=4">                   
                    <img src="https://avatars3.githubusercontent.com/u/6237180?s=60&v=4">                    
                </div>
            </div>
        </div>
        <div class="api-section">
            <div class="wrapper">
                <div class="media">
                    <div class="media-left hidden-xs">
                        <i class="fas fa-signature content-editors icon"></i>
                    </div>
                    <div class="media-body">
                        <a href="/content/content-managers"><h2 class="media-heading"><i class="fas fa-signature content-editors icon sm visible-xs-inline"></i>Content Managers</h2></a>
                        <p>
                            Hello, Content Manager! Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                             quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        </p>
                        <ul class="popular-topics">
                            <li style="border-bottom: 0;">Quick Links: </li>
                            <li><a href="/content/content-managers">Home</a></li>
                            <li><a href="/content/content-managers/content-manager-references/index.html">References</a></li>                            
                            <li><a href="http://dnndocs.com/content/content-managers/content-with-modules/content-managers-content-with-modules-overview/index.html">Creating Content With Modules</a></li>
                        </ul>
                    </div>
                </div>
                <div class="contributors hidden-xs">
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
                    <div class="media-left hidden-xs">
                        <i class="fas fa-code developers icon"></i>
                    </div>
                    <div class="media-body">
                        <a href="/content/developers"><h2 class="media-heading"><i class="fas fa-code developers icon sm visible-xs-inline"></i>Developers</h2></a>
                        <p>
                            Hello, Developer! Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                             quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        </p>
                        <ul class="popular-topics">
                            <li style="border-bottom: 0;">Quick Links: </li>
                            <li><a href="/content/developers">Home</a></li>
                            <li><a href="/content/developers/microservices/developers-microservices-overview/index.html">About Microservices</a></li>
                            <li><a href="/content/developers/about-modules/developers-about-modules-overview/index.html">Module (Extensions) Development</a></li>
                            <li><a href="/content/developers/mvc-modules/developers-mvc-modules-overview/index.html">MVC Module Development</a></li>
                            <li><a href="/content/developers/about-modules/spa-module-development/index.html">SPA Module Development</a></li>
                            <li><a href="/content/developers/about-modules/web-forms-module-development/index.html">Web Forms Module Development</a></li>
                        </ul>
                    </div>
                </div>
                <div class="contributors hidden-xs">
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
                    <div class="media-left hidden-xs">
                        <i class="fas fa-fill-drip designers icon"></i>
                    </div>
                    <div class="media-body">
                        <a href="/content/designers"><h2 class="media-heading"><i class="fas fa-fill-drip designers icon sm visible-xs-inline"></i>Designers</h2></a>
                        <p>
                            Hello, Designer! Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                             quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        </p>
                        <ul class="popular-topics">
                            <li style="border-bottom: 0;">Quick Links: </li>
                            <li><a href="/content/Designers">Home</a></li>
                            <li><a href="/content/designers/creating-themes">Creating Themes</a></li>
                            <li><a href="/content/designers/persona-bar-style-guide/">Persona Bar Style Guide</a></li>                            
                        </ul>
                    </div>
                </div>
                <div class="contributors hidden-xs">
                    <img src="https://avatars3.githubusercontent.com/u/4568451?s=60&v=4"> 
                    <img src="https://avatars0.githubusercontent.com/u/4571863?s=60&v=4">                    
                    <img src="https://avatars3.githubusercontent.com/u/6603270?s=60&v=4">                                                           
                </div>
            </div>
        </div>
        <!-- <div class="api-section">
            <div class="wrapper">
                <div class="media">
                    <div class="media-left hidden-xs">
                        <i class="fas fa-users community-managers icon"></i>
                    </div>
                    <div class="media-body">
                        <h2 class="media-heading"><i class="fas fa-users community-managers icon sm visible-xs-inline"></i>Community Managers</h2>
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
                <div class="contributors hidden-xs">
                    <img src="https://avatars3.githubusercontent.com/u/4568451?s=60&v=4"> 
                    <img src="https://avatars0.githubusercontent.com/u/4571863?s=60&v=4">                    
                    <img src="https://avatars3.githubusercontent.com/u/6603270?s=60&v=4">                                                           
                </div>
            </div>
        </div> -->
    </div>
</div>

<div id="contrib-container" class="home side-content">
    <h4 class="hlead"> <i class="fas fa-fire" style="color: #ee3a43"></i> Top Contributors</h4>    
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
    <h4 class="hlead"><i class="fas fa-fire-alt" style="color: #9F58A9"></i> Helpful Links</h4>    
        <ul class="popular-topics">
            <li>
                <a target="_blank" href="https://www.dnnsoftware.com/community-blog">Community Blog</a>
            </li>
            <li>
                <a target="_blank" href="http://dnnsoftware.org/">DNNSoftware.com</a>
            </li>
            <li>
                <a target="_blank" href="http://dnnsoftware.org/">DNNSoftware.org</a>
            </li>
            <li>
                <a target="_blank" href="https://github.com/dnnsoftware/Dnn.Platform">DNN on GitHub</a>
            </li>                       
        </ul>    
    <h4 class="hlead"><i class="fas fa-globe" style="color: #9F58A9"></i> Community</h4>
    <p>Learn more about DNN at these community events:</p>
    <ul class="events-list text-center">
        <li>
            <a class="visible-lg visible-xl" href="https://www.dnnsummit.org/" target="_blank">
                <img src="images/2019-SummitLogo.png">
            </a>
            <span class="details">Feb 19-23 2019<br>Denver</span>
        </li>
        <li>
            <a class="visible-lg visible-xl" href="https://www.dnn-connect.org/" target="_blank">
                <img src="images/dnnconnect-logo.png">
            </a>
            <span class="details">Jun 6-9 2019<br>Champery</span>
        </li>
        <li>
            <a class="visible-lg visible-xl" href="http://www.southernfrieddnn.com/" target="_blank">
                <img src="images/southernfried-logo.jpg">
            </a>
            <span class="details">3rd Thurs monthly<br>(online)</span>
        </li>
        <li>
            <a class="visible-lg visible-xl" href="https://www.meetup.com/Toronto-Area-DNN-User-Group-TADUG/" target="_blank">
                <img src="images/tadug-logo.jpg">
            </a>
            <span class="details">1st Thurs monthly<br>(online)</span>
        </li>
    </ul>
</div>

<script>
    (function() {
        document.addEventListener('DOMContentLoaded', function () {
            document.body.className += ' ' + 'homepage';
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


