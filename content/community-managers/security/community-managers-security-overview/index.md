---
topic: community-managers-security-overview
locale: en
title: Security
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: community-managers-overview
---

# Security

## Overview

Security for any website is comprised of two major components:

*   Authentication (AuthN). Verifies if the user provides valid login credentials.
*   Authorization (AuthZ). Determines which site content or settings the user has access to. DNN products use role-based authorization to simplify permission management. Administrators assign roles to users based on the user's function, and each role is pre-assigned access to relevant content and settings, based on the typical needs of someone in that role.

DNN provides several default authentication and role providers, and third-party developers can also extend DNN with custom providers.