import React from 'react'
import { withRouteData } from 'react-static'
import convert from 'htmr'

export default withRouteData(({ home }) => (
  <div>
    <section>
      {convert(home.contents)}
    </section>
  </div>
))
