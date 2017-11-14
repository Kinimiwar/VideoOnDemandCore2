﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace VideoOnDemand.Admin.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("page-button")]
    public class PageButtonTagHelper : TagHelper
    {
        #region Properties
        public string Path { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Glyph { get; set; } = string.Empty;
        public string BootstrapStyle { get; set; } = "btn-default";
        public string BootstrapSize { get; set; } = "btn-sm";
        #endregion

        public override void Process(TagHelperContext context,
        TagHelperOutput output)
        {
            if (context == null) throw new
                ArgumentNullException(nameof(context));
            if (output == null) throw new
                ArgumentNullException(nameof(output));

            base.Process(context, output);

            var href = "";

            if (Path.Trim().Length > 0)
            {
                // Assemble the value for the href parameter
                if (Path.StartsWith('/'))
                    href = $@"href='{Path.Trim()}'";
                else
                    href = $@"href='/{Path.Trim()}'";

                output.Content.AppendHtml($@"<a {href}>{Description}</a>");
            }
        }
    }
}