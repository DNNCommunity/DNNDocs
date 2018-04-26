
import React from 'react'
import { withRouteData } from 'react-static'
import convert from 'htmr'

export default withRouteData(({ content }) => (
  <div>
    {convert(content.contents)}
  </div>
))
