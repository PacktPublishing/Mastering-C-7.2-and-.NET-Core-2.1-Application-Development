using System.Threading.Tasks;
using CommonMark;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MarkdownHelper
{
    // Allow the tag to be used as <markdown> </markdown> or <markdown/>
    [HtmlTargetElement("markdown", TagStructure = TagStructure.NormalOrSelfClosing)]
    // Specify the tag element to use
    [HtmlTargetElement(Attributes = "markdown")]
    public class MarkdownTagHelper : TagHelper
    {
        public ModelExpression Content { get; set; }
        public async override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (output.TagName == "markdown")
            {
                output.TagName = null;
            }
            output.Attributes.RemoveAll("markdown");

            var content = await GetContent(output);
            var markdown = content;
            // Parse the markdown content
            var html = CommonMarkConverter.Convert(markdown);
            // Return the parsed markdown
            output.Content.SetHtmlContent(html ?? "");
        }

        private async Task<string> GetContent(TagHelperOutput output)
        {
            if (Content == null)
                return (await output.GetChildContentAsync()).GetContent();

            return Content.Model?.ToString();
        }
    }
}