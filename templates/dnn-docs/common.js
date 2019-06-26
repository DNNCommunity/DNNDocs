// Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. See LICENSE file in the project root for full license information.
exports.path = {};
exports.path.getFileNameWithoutExtension = getFileNameWithoutExtension;
exports.path.getDirectoryName = getDirectoryName;

exports.getHtmlId = getHtmlId;

exports.getViewSourceHref = getViewSourceHref;
exports.getImproveTheDocHref = getImproveTheDocHref;
exports.processSeeAlso = processSeeAlso;

exports.isAbsolutePath = isAbsolutePath;
exports.isRelativePath = isRelativePath;

exports.getHtmlUrl = getHtmlUrl;

exports.getTwitterShareHref = getTwitterShareHref;
exports.getLinkedInShareHref = getLinkedInShareHref;
exports.getFacebookShareHref = getFacebookShareHref;
exports.getEmailShareHref = getEmailShareHref;

exports.getFeedbackHref = getFeedbackHref;

function getHtmlUrl(_path) {
    if (!_path) return '';
    var dnndocsBaseUrl = 'https://dnndocs.com/';
    var htmlurl = dnndocsBaseUrl + _path.replace('.md', '.html');
    return htmlurl;
}

function getTwitterShareHref(_path, title) {
    if (!_path) return '';
    var dnndocsBaseUrl = 'https://dnndocs.com/';
    var original_referer = encodeURIComponent(dnndocsBaseUrl + _path.replace('.md', '.html'));
    var url = original_referer;
    var text = encodeURIComponent(title) + '%20%7C%20DNN%20Docs%20%7C%20%23DNNCMS';
    var tw_p = 'tweetbutton';
    var twitterShareHref = 'https://twitter.com/intent/tweet?original_referer=' + original_referer + '&text=' + text + '&tw_p=' + tw_p + '&url=' + url;
    return twitterShareHref;
}

function getLinkedInShareHref(_path) {
    if (!_path) return '';
    var dnndocsBaseUrl = 'https://dnndocs.com/';
    var url = encodeURIComponent(dnndocsBaseUrl + _path.replace('.md', '.html'));
    var linkedInShareHref = 'https://www.linkedin.com/cws/share?url=' + url;
    return linkedInShareHref;
}

function getFacebookShareHref(_path) {
    if (!_path) return '';
    var dnndocsBaseUrl = 'https://dnndocs.com/';
    var url = encodeURIComponent(dnndocsBaseUrl + _path.replace('.md', '.html'));
    var facebookShareHref = 'https://www.facebook.com/sharer/sharer.php?u=' + url;
    return facebookShareHref;
}

function getEmailShareHref(_path, title) {
    if (!_path) return '';
    var dnndocsBaseUrl = 'https://dnndocs.com/';
    var subject = '[Shared%20Article]%20' + encodeURIComponent(title) + '%20|%20DNN%20Docs';
    var body = encodeURIComponent(title) + '%20|%20DNN%20Docs%0A%0A' + encodeURIComponent(dnndocsBaseUrl + _path.replace('.md', '.html')) + '%0A%0A';
    return 'mailto:?subject=' + subject + '&body=' + body;
}

function getFeedbackHref(docurl, title, uid) {
    if (!docurl) return '';
    var newIssueUrl = 'https://github.com/DNNCommunity/DNNDocs/issues/new';
    title = 'Feedback for ' + title;
    var body = '%0A%0A%5BEnter%20feedback%20here%5D%0A%0A%0A---%0A%23%23%23%23%20Document%20Details%0A%0A%E2%9A%A0%20*Do%20not%20edit%20this%20section.%20It%20is%20required%20for%20dnndocs.com%20%E2%9E%9F%20Core%20Team%20processing.*%0A%0A*%20Content%20Source%3A%20%5B' + encodeURIComponent(uid) + '%5D(' + encodeURIComponent(docurl) + ')';
    return newIssueUrl + '?title=' + title + '&body=' + body;
}

function getFileNameWithoutExtension(path) {
    if (!path || path[path.length - 1] === '/' || path[path.length - 1] === '\\') return '';
    var fileName = path.split('\\').pop().split('/').pop();
    return fileName.slice(0, fileName.lastIndexOf('.'));
}

function getDirectoryName(path) {
    if (!path) return '';
    var index = path.lastIndexOf('/');
    return path.slice(0, index + 1);
}

function getHtmlId(input) {
    if (!input) return '';
    return input.replace(/\W/g, '_');
}

// Note: the parameter `gitContribute` won't be used in this function
function getViewSourceHref(item, gitContribute, gitUrlPattern) {
    if (!item || !item.source || !item.source.remote) return '';
    return getRemoteUrl(item.source.remote, item.source.startLine - '0' + 1, null, gitUrlPattern);
}

function getImproveTheDocHref(item, gitContribute, gitUrlPattern) {
    if (!item) return '';
    if (!item.documentation || !item.documentation.remote) {
        return getNewFileUrl(item, gitContribute, gitUrlPattern);
    } else {
        return getRemoteUrl(item.documentation.remote, item.documentation.startLine + 1, gitContribute, gitUrlPattern);
    }
}

function processSeeAlso(item) {
    if (item.seealso) {
        for (var key in item.seealso) {
            addIsCref(item.seealso[key]);
        }
    }
    item.seealso = item.seealso || null;
}

function isAbsolutePath(path) {
    return /^(\w+:)?\/\//g.test(path);
}

function isRelativePath(path) {
    if (!path) return false;
    return !exports.isAbsolutePath(path);
}

var gitUrlPatternItems = {
    'github': {
        // HTTPS form: https://github.com/{org}/{repo}.git
        // SSH form: git@github.com:{org}/{repo}.git
        // generate URL: https://github.com/{org}/{repo}/blob/{branch}/{path}
        'testRegex': /^(https?:\/\/)?(\S+\@)?(\S+\.)?github\.com(\/|:).*/i,
        'generateUrl': function (gitInfo) {
            var url = normalizeGitUrlToHttps(gitInfo.repo);
            url = getRepoWithoutGitExtension(url);
            url += '/blob' + '/' + gitInfo.branch + '/' + gitInfo.path;
            if (gitInfo.startLine && gitInfo.startLine > 0) {
                url += '/#L' + gitInfo.startLine;
            }
            return url;
        },
        'generateNewFileUrl': function (gitInfo, uid) {
            var url = normalizeGitUrlToHttps(gitInfo.repo);
            url = getRepoWithoutGitExtension(url);
            url += '/new';
            url += '/' + gitInfo.branch;
            url += '/' + getOverrideFolder(gitInfo.apiSpecFolder);
            url += '/new?filename=' + getHtmlId(uid) + '.md';
            url += '&value=' + encodeURIComponent(getOverrideTemplate(uid));
            return url;
        }
    },
    'vso': {
        // HTTPS form: https://{user}.visualstudio.com/{org}/_git/{repo}
        // SSH form: ssh://{user}@{user}.visualstudio.com:22/{org}/_git/{repo}
        // generated URL under branch: https://{user}.visualstudio.com/{org}/_git/{repo}?path={path}&version=GB{branch}
        // generated URL under detached HEAD: https://{user}.visualstudio.com/{org}/_git/{repo}?path={path}&version=GC{commit}
        'testRegex': /^(https?:\/\/)?(ssh:\/\/\S+\@)?(\S+\.)?visualstudio\.com(\/|:).*/i,
        'generateUrl': function (gitInfo) {
            var url = normalizeGitUrlToHttps(gitInfo.repo);
            var branchPrefix = /[0-9a-fA-F]{40}/.test(gitInfo.branch) ? 'GC' : 'GB';
            url += '?path=' + gitInfo.path + '&version=' + branchPrefix + gitInfo.branch;
            if (gitInfo.startLine && gitInfo.startLine > 0) {
                url += '&line=' + gitInfo.startLine;
            }
            return url;
        },
        'generateNewFileUrl': function (gitInfo, uid) {
            return '';
        }
    }
}

function getRepoWithoutGitExtension(repo) {
    if (repo.substr(-4) === '.git') {
        repo = repo.substr(0, repo.length - 4);
    }
    return repo;
}

function normalizeGitUrlToHttps(repo) {
    var pos = repo.indexOf('@');
    if (pos == -1) return repo;
    return 'https://' + repo.substr(pos + 1).replace(/:[0-9]+/g, '').replace(/:/g, '/');
}

function getNewFileUrl(item, gitContribute, gitUrlPattern) {
    // do not support VSO for now
    if (!item.source) {
        return '';
    }

    var gitInfo = getGitInfo(gitContribute, item.source.remote);
    if (!gitInfo.repo || !gitInfo.branch || !gitInfo.path) {
        return '';
    }

    var patternName = getPatternName(gitInfo.repo, gitUrlPattern);
    if (!patternName) return patternName;
    return gitUrlPatternItems[patternName].generateNewFileUrl(gitInfo, item.uid);
}

function getRemoteUrl(remote, startLine, gitContribute, gitUrlPattern) {
    var gitInfo = getGitInfo(gitContribute, remote);
    if (!gitInfo.repo || !gitInfo.branch || !gitInfo.path) {
        return '';
    }

    var patternName = getPatternName(gitInfo.repo, gitUrlPattern);
    if (!patternName) return '';

    gitInfo.startLine = startLine;
    return gitUrlPatternItems[patternName].generateUrl(gitInfo);
}

function getGitInfo(gitContribute, gitRemote) {
    // apiSpecFolder defines the folder contains overwrite files for MRef, the default value is apiSpec
    var defaultApiSpecFolder = 'apiSpec';

    var result = {};
    if (gitContribute && gitContribute.apiSpecFolder) {
        result.apiSpecFolder = gitContribute.apiSpecFolder;
    } else {
        result.apiSpecFolder = defaultApiSpecFolder;
    }
    mergeKey(gitContribute, gitRemote, result, 'repo');
    mergeKey(gitContribute, gitRemote, result, 'branch');
    mergeKey(gitContribute, gitRemote, result, 'path');

    return result;

    function mergeKey(source, sourceFallback, dest, key) {
        if (source && source.hasOwnProperty(key)) {
            dest[key] = source[key];
        } else if (sourceFallback && sourceFallback.hasOwnProperty(key)) {
            dest[key] = sourceFallback[key];
        }
    }
}

function getPatternName(repo, gitUrlPattern) {
    if (gitUrlPattern && gitUrlPattern.toLowerCase() in gitUrlPatternItems) {
        return gitUrlPattern.toLowerCase();
    } else {
        for (var p in gitUrlPatternItems) {
            if (gitUrlPatternItems[p].testRegex.test(repo)) {
                return p;
            }
        }
    }
    return '';
}

function getOverrideFolder(path) {
    if (!path) return "";
    path = path.replace('\\', '/');
    if (path.charAt(path.length - 1) == '/') path = path.substring(0, path.length - 1);
    return path;
}

function getOverrideTemplate(uid) {
    if (!uid) return "";
    var content = "";
    content += "---\n";
    content += "uid: " + uid + "\n";
    content += "summary: '*You can override summary for the API here using *MARKDOWN* syntax'\n";
    content += "---\n";
    content += "\n";
    content += "*Please type below more information about this API:*\n";
    content += "\n";
    return content;
}

function addIsCref(seealso) {
    if (!seealso.linkType || seealso.linkType.toLowerCase() == "cref") {
        seealso.isCref = true;
    }
}
