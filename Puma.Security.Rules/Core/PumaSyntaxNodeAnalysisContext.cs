/* 
 * Copyright(c) 2016 - 2020 Puma Security, LLC (https://pumasecurity.io)
 * 
 * Project Leads:
 * Eric Johnson (eric.johnson@pumascan.com)
 * Eric Mead (eric.mead@pumascan.com)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. 
 */

using Microsoft.CodeAnalysis.Diagnostics;

using Puma.Security.Rules.Common;

namespace Puma.Security.Rules.Core
{
    public class PumaSyntaxNodeAnalysisContext
    {
        public SyntaxNodeAnalysisContext RosylnContext { get; }

        public DiagnosticId DiagnosticId { get; }

        public PumaSyntaxNodeAnalysisContext(DiagnosticId diagnosticId, SyntaxNodeAnalysisContext context)
        {
            this.DiagnosticId = diagnosticId;
            this.RosylnContext = context;
        }
    }
}