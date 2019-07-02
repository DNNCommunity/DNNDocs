---
uid: relnotes-2019-apr-03
locale: en
title: DNN Release Notes — 2019 Apr 03
dnnversion: 09.03.01
---


# DNN Release Notes — v9.3.1 

Released 2019 Apr 03

We'd like to first thank everyone from the community and ESW who has submitted pull requests or reported issues. A grand total of 302 pull requests by 26 contributors were processed for this release. Out of that 105 were in the [Platform](https://github.com/dnnsoftware/Dnn.Platform/milestone/22?closed=1) repository, plus 157 additional pull requests were processed in the [Admin Experience](https://github.com/dnnsoftware/Dnn.AdminExperience/milestone/2?closed=1) repository. Below you can find a short list of the noteworthy changes in this release. For a full list, please check the GitHub milestone pages on each of the repositories.

## Known Potential Breaking Changes

If you currently use any 3rd party or in-house Persona Bar extensions which utilize the export bundle from the Admin Experience, they will need to be updated after upgrading to v9.3.1. Please see the Additional Resources section below for more information on this change.

## Changes Since 9.3.0
Fixed version issue with AdminExperience, CKEditor, FolderProviders, and JWT. These extensions were incorrectly versioned in the 9.3.0 release. This caused the upgrade process for v9.2.2 sites to skip upgrading those extensions. This resulted in an upgrade that appeared successful but was incomplete.

## Noteworthy Changes in 9.3.1

* NuGet Package Improvements. Thanks @mitchelsellers [#2600](https://github.com/dnnsoftware/Dnn.Platform/pull/2600)
* Enhanced the common tooltip component for accessibility within the Admin Experience. Thanks @valadas [#212](https://github.com/dnnsoftware/Dnn.React.Common/pull/212)
* Updated all React.Common packages to React 16 and created initial storyboards. Thanks @mtrutledge [#153](https://github.com/dnnsoftware/Dnn.React.Common/pull/153)
* Group Privacy Settings in Site Settings in a new tab. Thanks @donker [#99](https://github.com/dnnsoftware/Dnn.AdminExperience/issues/99)
* Enabled Greenkeeper on the Admin Experience repository. This updated all of our developer dependencies to their latest releases as-of Nov 5th 2018. We will continue to process the greenkeeper pull requests in future releases to keep things current. Thanks to @valadas, @mtrutledge, @nvisionative, @mean2me, @daguiler, @mikebigun, @Mhtshum and the rest of the team for all the long hours and 29+ pull requests to repair all the compilation and usability issues related to the major version changes between these dependencies. [#117](https://github.com/dnnsoftware/Dnn.AdminExperience/pull/117)
  * We ran into an issue with Greenkeeper and had to disable it during the initial RC. We will be setting up a similar service on for the v9.3.1 or v9.4.0 release scheduled for later this year.
* Added Cookie consent and configuration settings for Terms and Privacy pages. Thanks @donker [#2369](https://github.com/dnnsoftware/Dnn.Platform/pull/2369)
* Added UI connector to manage Google Analytic tracking. Thanks @mikesmeltzer [#2288](https://github.com/dnnsoftware/Dnn.Platform/pull/2288)
* Performance fix for CoreMessaging and Journal procedures. Thanks @ChrisHammond [#2342](https://github.com/dnnsoftware/Dnn.Platform/pull/2342)
* Performance & stability fix for Azure & other Environments. Thanks @cameron-moore [#2032](https://github.com/dnnsoftware/Dnn.Platform/pull/2032)
* On hover, we are now showing the pane name again when in edit mode. Thanks @zyhfish [#19](https://github.com/dnnsoftware/Dnn.AdminExperience/pull/19)
* Added attributes for improving accessibility in the Admin Experience. Thanks @OllyHodgson [#36](https://github.com/dnnsoftware/Dnn.AdminExperience/pull/36)
* Added UI for Small and Large Page Icons back into Page Settings. Thanks @valadas [#111](https://github.com/dnnsoftware/Dnn.AdminExperience/pull/111)
* Added UI for Host Email setting under SMTP Configuration. Thanks @valadas [#39](https://github.com/dnnsoftware/Dnn.AdminExperience/pull/39)
* Added Azure DevOps to React.Common to verify pull requests and publish new releases of the npm packages. Thanks @ohine and @mtrutledge
* Resolved issue with viewing/editing user profiles on certain pages with http/https differences. Thanks @mean2me [#2494](https://github.com/dnnsoftware/Dnn.Platform/pull/2494)

## List of Contributors for v9.3.1

* Matt Rutledge @mtrutledge
* Daniel Valadas @valadas
* Stefan Kamphuis @skamphuis
* Andrew Hoefling @ahoefling
* David Poindexter @nvisionative
* Brian Dukes @bdukes
* Oliver Hine @ohine
* Joshua Bradley @JoshuaBradley
* Olly Hodgson @OllyHodgson
* Mitchel Sellers @mitchelsellers
* Mohtisham Zubair @Mhtshum, @Mohtshum
* Mike Smeltzer @mikesmeltzer
* Peter Donker @donker
* Sebastian Leupold @sleupold
* Ernst Peter Tamminga @EPTamminga
* Chris Hammond @ChrisHammond
* Cameron Moore @cameron-moore
* Behnam Emamian @Behnam-Emamian
* Tomasz Pluskiewicz @tpluscode
* Mikhail Bigun @mikebigun
* Anish Mishra @anishmishra978
* Ben Zhong @zyhfish
* Daniel Aguilera @daguiler
* Ryan Gunn @Icidis
* Sacha @sachatrauwaen
* Emanuele Colonnelli @mean2me
* Stefan Cullmann @SCullman
* @noor-zubair

## Additional Resources

* [Upgrading Persona Bar Components Guide](https://www.dnnsoftware.com/community-blog/cid/156674/upgrading-persona-bar-components-for-dnn-93) - Matt Rutledge wrote an excellent guide to help you with that process.

## Downloads
* [https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.3.1](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.3.1)