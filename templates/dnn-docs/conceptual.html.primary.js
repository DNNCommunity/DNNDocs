// Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. See LICENSE file in the project root for full license information.

var common = require('./common.js');
var extension = require('./conceptual.extension.js')

exports.transform = function (model) {
  if (extension && extension.preTransform) {
    model = extension.preTransform(model);
  }

  model._disableToc = model._disableToc || !model._tocPath || (model._navPath === model._tocPath);
  model.docurl = model.docurl || common.getImproveTheDocHref(model, model._gitContribute, model._gitUrlPattern);
  model._dnneditions = common.beautifyDnnEditions(model.dnneditions);
  model._emailShareHref = common.getEmailShareHref(model.docurl, model.title);
  model._twitterShareHref = common.getTwitterShareHref(model.docurl, model.title);
  model._feedbackurl = common.getFeedbackHref(model.docurl, model.title, model.uid);

  if (extension && extension.postTransform) {
    model = extension.postTransform(model);
  }

  return model;
}