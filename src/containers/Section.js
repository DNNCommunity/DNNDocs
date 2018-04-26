
import React from 'react'
import { withRouteData, Link } from 'react-static'

export default withRouteData(({ concepts }) => (
  <div>
    <br />
    DNN Concepts:
    <ul>
      {concepts.map(topic => (
        <li key={topic.slug}>
          <Link to={`/concepts/${topic.slug}/`}>{topic.title}</Link>
        </li>
      ))}
    </ul>
  </div>
))
