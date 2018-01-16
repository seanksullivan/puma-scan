﻿/* 
 * Copyright(c) 2016 - 2018 Puma Security, LLC (https://www.pumascan.com)
 * 
 * Project Leader: Eric Johnson (eric.johnson@pumascan.com)
 * Lead Developer: Eric Mead (eric.mead@pumascan.com)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. 
 */

using System.Collections.Immutable;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

using Puma.Security.Rules.Analyzer;
using Puma.Security.Rules.Core;
using Puma.Security.Rules.Analyzer.Validation.Redirect;

namespace Puma.Security.Rules.Suites
{
    [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
    public class UnvalidatedRedirectDiagnosticSuite : BaseSyntaxDiagnosticSuite
    {
        public UnvalidatedRedirectDiagnosticSuite()
        {
            Analyzers = new ISyntaxAnalyzer[]
            {
                new MvcRedirectAnalyzer(),
                new ResponseRedirectAnalyzer(),
            }.ToImmutableArray();
        }
    }
}