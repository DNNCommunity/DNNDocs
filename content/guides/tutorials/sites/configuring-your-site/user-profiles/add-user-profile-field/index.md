---
uid: add-user-profile-field
locale: en
title: Add a User Profile Field
dnnversion: 09.02.00
related-topics: configure-user-profile-visibility,configure-user-profile-vanity-url,edit-user-profile-field,delete-user-profile-field,organize-user-profile-fields
---

# Add a User Profile Field

## Prerequisites

*   **An administrator account for the site.** Administrators have full permissions to the specific site.

## Steps

1.  Go to **Persona Bar \> Settings \> Site Settings**.
    
    ![Persona Bar > Settings > Site Settings](/images/scr-pbar-host-Settings-E91.png)
    
2.  Go to the Site Behavior tab, and then the **User Profiles** subtab.
    
    ![Site Behavior > User Profiles](/images/scr-pbtabs-host-Settings-SiteSettings-SiteBehavior-UserProfiles-E90.png)
    
3.  Click/Tap \+ **Add Field**.
    
      
    
    ![Site Settings > Site Behavior > User Profiles > User Profile Fields > Add](/images/scr-SiteSettings-SiteBehavior-UserProfiles-UserProfileFields-Add-E90.png)
    
      
    
4.  Configure the properties of the new field.
    
      
    
    ![Site Settings > Site Behavior > User Profiles > User Profile Fields > New Field](/images/scr-SiteSettings-SiteBehavior-UserProfiles-UserProfileFields-NewField-E90.png)
    
      
    
    |**Field**|**Description**|
    |---|---|
    |<strong>Field Name</strong>|The internal name for this field. This field name cannot be modified after the new field is saved. You can enter different field labels for different countries/cultures in the next page.|
    |<strong>Property Category</strong>|Fields with the same property category are grouped together when displayed in the user profile page. Note: Also used as the category's tab label un the user profile page.The default fields are grouped in the following categories: <ul><li><strong>Name</strong></li><li><strong>Address</strong></li><li><strong>Contact Info</strong></li><li><strong>Preferences</strong></li></ul> ![Property Categories in the user profile page](/images/scr-UserProfile-PropertyCategories.png)|
    |<strong>Default Value</strong>|(Optional) The value used if the user does not enter a value.|
    |<strong>Required</strong>|If enabled, the user must provide a value for this field.|
    |<strong>Visible</strong>|If enabled, the user can edit this field in their own profile. Otherwise, only the administrators and hosts/superusers can.|
    |<strong>Default Visibility</strong>|The default set of other users who can view this field on a user's profile. Options include:<ul><li><strong>All Users</strong>: Including anonymous users.</li><li><strong>Members Only</strong>: Registered users only.</li><li><strong>Admin Only</strong>: Administrators and hosts/superusers only.</li><li><strong>Friends and Group</strong>: Friends of the user and members of groups that the user belongs to.</li></ul>If Display Profile Visibility is enabled, the user can change this setting for each field in their own profile.|
    |<strong>Data Type</strong>|Options include:<ul><strong><li>AutoComplete</li><li>Checkbox</li><li>Country</li><li>List</li><li>Locale</li><li>Page</li><li>Region</li><li>RichText</li><li>TimeZone</li><li>Integer</li><li>Multi-line Text</li><li>Text</li><li>TrueFalse</li><li>Image</li><li>TimeZoneInfo</li><li>Date</li><li>DateTime</li><li>Unknown</li>|
    |<strong>Length</strong>|The maximum number of single-byte characters allowed in the field. This restriction applies to certain data types, such as Text.|
    |<strong>Validation Expression</strong>|A regular expression used to validate the value entered in this field. Example: To accept only email addresses from the example.com domain, use `[a-zA-Z0-9._%+-]+@example.com` .|
    |<strong>Read Only</strong>|If enabled, the field can be edited only by administrators and hosts/superusers.|
    |<strong>View Order</strong>| The position of the field, relative to the list of fields displayed in the user profile page. Automatically assigned and adjusted every time a new field is added or a field in the list is moved.|
