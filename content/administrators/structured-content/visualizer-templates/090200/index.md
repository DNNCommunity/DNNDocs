---
topic: visualizer-templates
locale: en
title: Visualizer Templates
dnneditions: Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-structured-content-overview
related-topics: example-recipes
---

# Visualizer Templates

  

![Content > Visualizers tab > Editor > Template](img/scr-Visualizers-Editor-Template-E91.gif)

  

After you choose the content type in the Details tab, the Template editor is populated with the placeholders for each field in the selected content type. You can pipe the values of the placeholders into filters that perform additional changes to the result.

Example: Without filters, a Date / Time field would return the full date and the full time. If you want to display only the time, you must pipe the value to the `date` filter with the mask `"HH:mm"`, which displays the time in the 24-hour format: `{{meetingTimeslot | date: "HH:mm"}}`