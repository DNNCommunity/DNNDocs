
import React from 'react'
import { Link } from 'react-static'

export default () => (
  <nav>
    <ul>
      <li>Overview</li>
      <li>Installation</li>
      <li><Link to="/concepts">Concepts</Link>
        <ul>
          <li>Architecture</li>
          <li>Extensions
            <ul>
              <li>Modules</li>
              <li>Language Packs</li>
              <li>Providers</li>
              <li>Libraries</li>
              <li>Themes</li>
            </ul>
          </li>
          <li>Users &amp; Roles
            <ul>
              <li>Creating a User</li>
              <li>Creating a Role</li>
              <li>Assigning a Role to a User</li>
            </ul>
          </li>
          <li>Pages</li>
          <li>Automated Processes</li>
          <li>Database
            <ul>
              <li>DAL2</li>
              <li>Peta Poco</li>
              <li>Connections</li>
              <li>Cache</li>
            </ul>
          </li>
          <li>Web.config</li>
        </ul>
      </li>
    </ul>
  </nav>
)
