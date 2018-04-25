import React from 'react'
import { Router, Link } from 'react-static'
import { hot } from 'react-hot-loader'
//
import Routes from 'react-static-routes'
import Nav from './Nav';

import './app.scss'

const App = () => (
  <Router>
    <div>
      <nav className="top-nav">
        <svg className="logo" data-name="Layer 1" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1103.72 1103.72">
          <path d="M696.37,19.13A553.06,553.06,0,0,0,551.86,0H0V696.44H367.86V367.93H696.3l.07-348.8Zm39.42,12.23h0v336.5h336.49A553.51,553.51,0,0,0,735.79,31.36Zm348.79,375.92H735.79V552.07h0c-.15,101.43-82.44,183.72-183.93,183.72H407.35v367.93H551.86c304.77,0,551.86-247.09,551.86-551.86A551.4,551.4,0,0,0,1084.58,407.28ZM0,1103.72H367.86V735.79H0Z"/>
        </svg>
        <Link to="/">Home</Link>
        <Link to="/develop" className="is-active">Developers</Link>
        <Link to="/design">Designers</Link>
        <Link to="/api">API</Link>
        <Link to="/about">About</Link>
      </nav>
      <div class="container">
        <div className="sidebar">
          <Nav />
        </div>
        <div className="content">
          <Routes />
        </div>
      </div>
    </div>
  </Router>
)

export default hot(module)(App)
