---
uid: image-handler
locale: en
title: Image Handler
dnnversion: 08.00.00
links: ["[DNN Blog: DnnImageHandler - hot or not ?](https://www.dnnsoftware.com/community-blog/cid/155173/dnnimagehandler--hot-or-not-)", "[DNN Blog: DNN Imagehandler](https://www.dnnsoftware.com/community-blog/cid/155618/dnn-imagehandler)"]
---

# Image Handler

Out of the box, DNN includes an endpoint which can retrieve, transform, and serve images from your DNN site.  This feature can be used by developers within their modules, designers within their themes, and content creators in their content.

## Modes

The image handler is find, create, and serve many types of images, so it first needs to know the **mode** in which it is operating.

| URL                                                                 | Purpose
|---------------------------------------------------------------------|----------------------------------------
| `/DnnImageHandler.ashx?mode=profilepic&userid=330894`               | Display the profile picture of a user
| `/DnnImageHandler.ashx?mode=file&file=/Images/Logo.jpg`             | Display an image from a path
| `/DnnImageHandler.ashx?mode=file&url=https://placebear.com/200/100` | Display an image from an external URL
| `/DnnImageHandler.ashx?mode=securefile&fileid=317624`               | Display an image from a file ID
| `/DnnImageHandler.ashx?mode=placeholder&w=200&h=100`                | Generate and display a placeholder image

Additionally, it is possible to extend the image handler with [custom modes](#custom-modes).

### Profile Mode

TODO: Info about profile and its constraints

### Placeholder Mode

TODO: Info about options for generating placeholder images

## Resize

TODO: Info about resizing images

## Filters

You can also apply filters to the images

* [Greyscale](#greyscale-filter)
* [Invert](#invert-filter)
* [Contrast](#contrast-filter)
* [Gamma](#gamma-filter)
* [Brightness](#brightness-filter)
* [Rotate/Flip](#rotate-flip-filter)

### Greyscale Filter

Add the `&greyscale=1` parameter to the URL to get the greyscale version of the image

### Invert Filter

Add the `&invert=1` parameter to the URL to invert the colors, i.e. get the "negative" of the image

### Contrast Filter

The contrast of the image can be adjusted, using values between `-100` and `100`, e.g. `&contract=-50`

### Gamma Filter

The gamma value of the image can be adjusted, using values between `0.2` and `5.0`, e.g. `&gamma=1`

### Brightness Filter

The brightness of the image can be adjusted, using values between `-255` and `255`, e.g. `&brightness=-75`

### Rotate/Flip Filter

The image can be rotated and/or flipped using the `rotateflip` parameter.  For example `&rotateflip=RotateNoneFlipY` or `&rotateflip=Rotate180FlipNone`

## Custom Modes

The image handler is based on a project by Torsten Weggen, and he has a [collection of extensions](https://github.com/weggetor/BBImageHandler-8) to the version built into DNN that add extra modes.  This project also serves as a collection of examples for how to create your own custom mode.  The project includes modes such as Database Image, Barcode, Thermometer, and Web Thumbnail.

Creating your own mode involes implementing a .NET class that inherits from [`DotNetNuke.Services.GeneratedImage.ImageTransform`](xref:DotNetNuke.Services.GeneratedImage.ImageTransform), which primarily involves generating an [`Image`](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.image) value.  Public properties on the class are automatically able to by set via the query string.
