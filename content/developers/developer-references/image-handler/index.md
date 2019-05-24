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

When using `mode=profilepic`, the picture from a user's profile is retrieved and displayed.  The user's ID is supplied via the `userid` parameter.  If no picture is defined for the user, a default avatar is displayed from `/images/no_avatar.gif`.

When [resizing](#resize) a profile picture, the [`resizemode`](#resize-modes) parameter cannot be adjusted.  It will be `FitSquare` if only one dimension is provided, or if both height and width are equal (meaning that images which are not square will have white added on the narrow sides to create a square).  If both height and width are provided, the resize mode will be `Fill`, meaning that the image will stretch, without regard to aspect ratio, to the requested size.

### Placeholder Mode

When using `mode=placeholder`, a placeholder image will be generated.  You must specify dimensions for the image, using `w` and `h` parameters, and also have the option to specify `text`, `color` and `backcolor` parameters.  If not supplied, the text will default to `{width}x{height}`, the text color will be [`LightGray`, i.e. #D3D3D3](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.color.lightgray), and the background color will be [`LightSlateGray`, i.e. #778899](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.color.lightslategray).  The two color parameters can use a [`KnownColor`](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.knowncolor) name, or a hexadecimal RGB representation (note that the `#` at the start of the hexadecimal color must be URL encoded on the URL as `%23`).

### Examples

| URL | Image
| --- | -----
| `/DnnImageHandler.ashx?mode=placeholder&w=200&h=50` | ![200x50 placeholder image](https://www.dnnsoftware.com/DnnImageHandler.ashx?mode=placeholder&w=200&h=50)
| `/DnnImageHandler.ashx?mode=placeholder&w=200&h=50&text=banner` | ![200x50 placeholder image with "banner" text](https://www.dnnsoftware.com/DnnImageHandler.ashx?mode=placeholder&w=200&h=50&text=banner)
| `/DnnImageHandler.ashx?mode=placeholder&w=200&h=50&color=BlueViolet` | ![200x50 placeholder image with blue-violet text and border](https://www.dnnsoftware.com/DnnImageHandler.ashx?mode=placeholder&w=200&h=50&color=BlueViolet)
| `/DnnImageHandler.ashx?mode=placeholder&w=200&h=50&backcolor=orange` | ![200x50 placeholder image with orange background](https://www.dnnsoftware.com/DnnImageHandler.ashx?mode=placeholder&w=200&h=50&backcolor=orange)
| `/DnnImageHandler.ashx?mode=placeholder&w=200&h=50&text=DNN%20Summit&color=%231e355e&backcolor=%23e77e3a` | ![200x50 placeholder image with "DNN Summit" text](https://www.dnnsoftware.com/DnnImageHandler.ashx?mode=placeholder&w=200&h=50&text=DNN%20Summit&color=%231e355e&backcolor=%23e77e3a)

## Resize

One of the primary reasons someone might want to use the image handler is to resize images, and prevent users from downloading excessively large images (you may want to use [`srcset`](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/img#attr-srcset) or [`<picture>`](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/picture) to serve different sized based on the browser's viewport size).

To get started resizing, you can just add a `w` or `h` parameter to set the width and/or height.  You can adjust the behavior of the resizing by specifying a resize mode.

## Resize Modes

There are four [resize modes](xref:DotNetNuke.Services.GeneratedImage.ImageResizeMode) supported when resizing, specified via the `resizemode` parameter.

| Name        | Description
| ----------- | -----------
| `Crop`      | Removes parts of the image to ensure the resulting image is the correct size
| `Fill`      | Resizes the image without maintaining the aspect ratio, i.e. streches or squishes the image
| `Fit`       | Resizes the image while maintaining the aspect ratio, ensuring the image fits within the given dimensions
| `FitSquare` | Resizes the image and centers it on a generated background (white by default)

The color of the generated background ca be specified via the `backcolor` parameter (documented in the [Placeholder Mode](#placeholder-mode) section).  A border can also be added in this same color by specifying its width in the `border` parameter, e.g. `border=10`

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

The image can be rotated and/or flipped using the `rotateflip` parameter.  The value for the parameter will be in the format `Rotate{degrees}Flip{axis}`.  The valid values for `degrees` are `None`, `90`, `180`, and `270`.  The valid values for `axis` are `None`, `X`, `Y`, and `XY`.  For example `&rotateflip=RotateNoneFlipY`, `&rotateflip=Rotate180FlipNone`, `&rotateflip=Rotate270FlipXY`.

## Custom Modes

The image handler is based on a project by Torsten Weggen, and he has a [collection of extensions](https://github.com/weggetor/BBImageHandler-8) to the version built into DNN that add extra modes.  This project also serves as a collection of examples for how to create your own custom mode.  The project includes modes such as Database Image, Barcode, Thermometer, and Web Thumbnail.

Creating your own mode involes implementing a .NET class that inherits from [`DotNetNuke.Services.GeneratedImage.ImageTransform`](xref:DotNetNuke.Services.GeneratedImage.ImageTransform), which primarily involves generating an [`Image`](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.image) value.  Public properties on the class are automatically able to by set via the query string.
