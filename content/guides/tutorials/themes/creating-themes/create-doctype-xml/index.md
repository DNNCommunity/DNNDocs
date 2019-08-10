---
uid: create-doctype-xml
locale: en
title: Create a DocType XML
dnnversion: 09.02.00
previous-topic: create-css
related-topics: themes
links: ["[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Community blog: DotNetNuke Skinning 101 (Part 2) by Joe Brinkman](https://www.dnnsoftware.com/community-blog/cid/131999/dotnetnuke-skinning-101-part-2)"]
---

# Create a DocType XML

A design intended to be viewed using HTML 5 will not look correct if rendered using the XHTML or HTML 4 specification. You can force the theme to be rendered in XHTML or HTML5 by creating a DocType XML file (skin.doctype.xml), which is applied to all layouts in the theme. In addition, themes can contain a separate DocType file for any individual layout template to override the theme's DocType declaration.

> [!NOTE]
> By default, DNN uses the HTML 4.0 Transitional DocType (`<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">`), if no Theme DocType is specified. But this Fallback doctype can be changed.

> [!NOTE]
> In DNN 8 you can set the Fallback DocType via **Host \> Host Settings**.

> [!NOTE]
> In DNN 9 there's currently no interface for this, but you can create or edit a record in the "HostSettings" table. SettingName: 'DefaultDocType' / SettingValue: 3, will set the Fallback Doctype to HTML5.

## Steps

1.  Create a DocType XML file.

    *   If the DocType is for the entire theme, the file must be named **skin.doctype.xml**.
    *   If the DocType is for a specific layout template, the file must have the same name as your layout template file, followed by **.doctype.xml**.

    If your layout template file is called MyAwesomeLayout.html, its specific DocType file must be named MyAwesomeLayout.doctype.xml.

2.  Enter the appropriate code in your DocType file.

    *   HTML5

        ```

            <SkinDocType>
                <![CDATA[<!DOCTYPE html>]]>
            </SkinDocType>

        ```
    
    *   XHTML Strict

        ```

            <SkinDocType>
                <![CDATA[<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "https://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">]]>
            </SkinDocType>

        ```

    *   XHTML Transitional

        ```

            <SkinDocType>
                <![CDATA[<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">]]>
            </SkinDocType>

        ```

     
    *   HTML 4.01 Transitional

        ```

            <SkinDocType>
                <![CDATA[<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "https://www.w3.org/TR/html4/loose.dtd">]]>
            </SkinDocType>

        ```
