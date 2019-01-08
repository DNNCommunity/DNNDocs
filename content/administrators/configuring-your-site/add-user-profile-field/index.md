---
uid: add-user-profile-field
topic: add-user-profile-field
locale: en
title: Add a User Profile Field
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-configuring-your-site-overview
related-topics: configure-user-profile-visibility,configure-user-profile-vanity-url,edit-user-profile-field,delete-user-profile-field,organize-user-profile-fields
---

# Add a User Profile Field

## Prerequisites

*   **An administrator account for the site.** Administrators have full permissions to the specific site.

## Steps

1.  Go to Persona Bar \> Settings \> Site Settings.
    
    ![Persona Bar > Settings > Site Settings](/images/scr-pbar-host-Settings-E91.png)
    
    ➊
    
    ➋
    
2.  Go to the Site Behavior tab, and then the User Profiles subtab.
    
    ![Site Behavior > User Profiles](/images/scr-pbtabs-host-Settings-SiteSettings-SiteBehavior-UserProfiles-E90.png)
    
3.  Click/Tap \+ Add Field.
    
      
    
    ![Site Settings > Site Behavior > User Profiles > User Profile Fields > Add](/images/scr-SiteSettings-SiteBehavior-UserProfiles-UserProfileFields-Add-E90.png)
    
      
    
4.  Configure the properties of the new field.
    
      
    
    ![Site Settings > Site Behavior > User Profiles > User Profile Fields > New Field](/images/scr-SiteSettings-SiteBehavior-UserProfiles-UserProfileFields-NewField-E90.png)
    
      
    
    Field
    
    Description
    
    Field Name
    
    The internal name for this field. This field name cannot be modified after the new field is saved. You can enter different field labels for different countries/cultures in the next page.
    
    Property Category
    
    Fields with the same property category are grouped together when displayed in the user profile page.
    
    Note: Also used as the category's tab label un the user profile page.
    
    The default fields are grouped in the following categories:
    
    *   Name
    *   Address
    *   Contact Info
    *   Preferences
    
      
    
    ![Property Categories in the user profile page](/images/scr-UserProfile-PropertyCategories.png)
    
      
    
    Default Value
    
    (Optional) The value used if the user does not enter a value.
    
    Required
    
    If enabled, the user must provide a value for this field.
    
    Visible
    
    If enabled, the user can edit this field in their own profile. Otherwise, only the administrators and hosts/superusers can.
    
    Default Visibility
    
    The default set of other users who can view this field on a user's profile. Options include:
    
    *   All Users. Including anonymous users.
    *   Members Only. Registered users only.
    *   Admin Only. Administrators and hosts/superusers only.
    *   Friends and Group. Friends of the user and members of groups that the user belongs to.
    
    If Display Profile Visibility is enabled, the user can change this setting for each field in their own profile.
    
    Data Type
    
    Options include:
    
    *   AutoComplete
    *   Checkbox
    *   Country
    *   List
    *   Locale
    *   Page
    *   Region
    *   RichText
    *   TimeZone
    *   Integer
    *   Multi-line Text
    *   Text
    *   TrueFalse
    *   Image
    *   TimeZoneInfo
    *   Date
    *   DateTime
    *   Unknown
    
    Length
    
    The maximum number of single-byte characters allowed in the field. This restriction applies to certain data types, such as Text.
    
    Validation Expression
    
    A regular expression used to validate the value entered in this field. Example: To accept only email addresses from the example.com domain, use `[a-zA-Z0-9._%+-]+@example.com` .
    
    Read Only
    
    If enabled, the field can be edited only by administrators and hosts/superusers.
    
    View Order
    
    The position of the field, relative to the list of fields displayed in the user profile page. Automatically assigned and adjusted every time a new field is added or a field in the list is moved.