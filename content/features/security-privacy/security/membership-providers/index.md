---
uid: security-membership-providers
locale: en
title: Membership Providers
dnneditions: DNN Platform
dnnversion: 10.01.00
---

# Membership Providers

DNN Platform uses a provider-based membership system that allows for flexible user account management mechanisms. This extensible architecture enables DNN to support various membership providers while maintaining a consistent interface for developers and administrators.

## Default Membership Provider

DNN Platform uses **AspNetSqlMembershipProvider** as its default membership provider. This is a built-in membership provider that uses SQL Server for storing user account information and credentials.

### Key Features of AspNetSqlMembershipProvider

- **SQL Server integration**: User accounts and credentials are stored in SQL Server database tables
- **Password management**: Handles password hashing, validation, and security
- **User validation**: Provides methods for validating user credentials during login
- **Account management**: Supports user creation, deletion, and profile management

## Password Storage Formats

The ASP.NET Membership Provider supports multiple password storage formats through its configuration. Understanding these formats is crucial for security planning and migration strategies when working with DNN Platform.

### Supported Password Formats

#### Hashed (Recommended)
- **Security Level**: Highest
- **Default Since**: DNN 7.1.0
- **Hashing Algorithm**: 
  - SHA1 (DNN 7.1.0 - 10.1.0)
  - SHA256 (DNN 10.2.x) - Enhanced security with stronger hashing
- **Description**: Passwords are irreversibly hashed using cryptographic algorithms. This is the most secure option as original passwords cannot be recovered even if the database is compromised.
- **Recovery**: Password reset required - original passwords cannot be retrieved (see [Force Password Reset](#force-password-reset))

#### Encrypted
- **Security Level**: Medium
- **Default**: DNN versions prior to 7.1.0
- **Description**: Passwords are encrypted using reversible encryption. While more secure than plain text, this method is less secure than hashing.
- **Recovery**: Passwords can be decrypted and recovered if needed

#### Clear (Plain Text) - NOT RECOMMENDED
- **Security Level**: None
- **Description**: Passwords are stored in plain text format without any protection
- **Security Risk**: Extremely dangerous - passwords are visible to anyone with database access
- **Use Case**: Should never be used in production environments

### Version History and Defaults

| DNN Version | Default Format | Hashing Algorithm |
|-------------|----------------|-------------------|
| Pre-7.1.0   | Encrypted      | N/A               |
| 7.1.0+      | Hashed         | SHA1              |
| 10.2.0+     | Hashed         | SHA256            |

### Security Recommendations

1. **Always use Hashed format** in production environments. [learn how to migrate](#migration-from-encrypted-to-hashed)
2. **Upgrade to SHA256** when using DNN 10.2.0 or later for enhanced security. [learn how to migrate](#changing-from-sha-1-to-sha-256)
3. **Never use Clear (plain text)** format except for development/testing purposes
4. **Plan migration strategy** when upgrading from older DNN versions with encrypted passwords
5. **Implement strong password policies** regardless of storage format

### Configuration

Password format is configured in the `web.config` file under the membership provider settings:

```xml
<membership>
  <providers>
    <add name="AspNetSqlMembershipProvider" 
         passwordFormat="Hashed" 
         hashAlgorithmType="SHA256" />
  </providers>
</membership>
```

### Microsoft Documentation

For detailed information about ASP.NET Membership Providers, refer to the official Microsoft documentation:

- [Introduction to Membership](https://docs.microsoft.com/en-us/previous-versions/aspnet/yh26yfzy(v=vs.100))
- [Understanding ASP.NET Membership](https://docs.microsoft.com/en-us/previous-versions/aspnet/tw292whz(v=vs.100))
- [ASP.NET Membership Provider Toolkit](https://docs.microsoft.com/en-us/previous-versions/aspnet/6e9y4s5t(v=vs.100))

### Custom Providers
Developers can create custom membership providers by implementing the `MembershipProvider` abstract class and configuring them in the DNN provider configuration.

## Configuration

Membership providers are configured in the `web.config` file under the `system.web/membership` section. The default AspNetSqlMembershipProvider is configured automatically during DNN installation.

## Force Password Reset

There are scenarios where administrators need to force all users to reset their passwords, such as:

- After upgrading password storage formats (e.g., from Encrypted to Hashed)
- Following a security incident or suspected breach
- Implementing new password policies

### Migration from "encrypted" to "hashed"
To change the password format in DNN from encrypted to hashed, you must edit the web.config file and change the passwordFormat attribute to `Hashed` within the <add name="AspNetSqlMembershipProvider" ... /> section, and simultaneously set `enablePasswordRetrieval` to `false`. After this change, existing users' encrypted passwords will be converted to hashed passwords when they update their password.

To force all users to reset their passwords, you can execute the following SQL query against your DNN database:

> ⚠️ **Important**: Always backup your database before executing any direct SQL modifications. Also, the default method to reset a password involves sending a verification link by email. Make sure emails work correctly and that your own superuser acccount has a proper email where you can receive that link.

```sql
-- Force password reset for all users
UPDATE Users 
SET UpdatePassword = 1
```

> 💡Is it critical to migrate from Encrypted to Hashed?
Encrypted passwords use a 2-way encryption. This means that if any hacker gets a hold on the web.config file and the database, they will **easily** be able to decrypt ALL passwords. Hashed uses a one-way encryption method which means that passwords can't be reversed. Should a hacker obtain the database and web.config file, they can't reverse any password directly, they would have to invest quite a large amount of computing resources to reverse a single password (especially since DNN also uses a per-user password salt). We strongly encourage to migrate any site that uses "Encrypted" to "Hashed" as it quickly improves security tremendously.

### Changing from SHA-1 to SHA-256

> ⚠️ **Warning**: Because hashed passwords cannot be decrypted, this change will prevent any logins with the existing passwords (including super-users), which may be confusing for users. To help avoid confusion you may want to notify all your users about having to reset their passwords for better security. They will have to click on "Reset Password" to migrate to the new format. They will be able to enter their username and receive a special link by email to reset their password using a token.

> 💡You can check the `LastPasswordChangedDate` in the `aspnet_Membership` table to see which users did change their passwords or not after the date of that change. You may use that information to later delete users that may no longer be activivally engaged. Additionally you can wipe the `Password` field if you want to make sure no passwords with the old algorithm are kept (before notifying users about the change).

> 💡**Is it critical to migrate from SHA1 to SHA256?**
SHA-1 has known collision weaknesses and is discouraged by most cryptographic compliance standards. Collisions aren’t a practical concern in per-user salted password storage, but some auditors or clients will flag any use of SHA-1 regardless of context. Moving to SHA-256 aligns better with PCI-DSS, NIST, ISO, and similar standards.
Migrating from SHA-1 to SHA-256 in ASP.NET Membership improves cryptographic hygiene and helps with compliance, but offers only modest real-world password security benefits while introducing migration overhead. It is a technical enhancement, though not as impactful as upgrading from "encrypted" to "hashed".