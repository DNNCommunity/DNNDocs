
import React from 'react'
import { withRouteData } from 'react-static'
import convert from 'htmr'

export default withRouteData(({ api }) => (
  <div>
    {convert(api.contents)}
  </div>
))
