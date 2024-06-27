using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Semantica.Linq;
using Semantica.Patterns;

namespace Semantica.Mvc.Rendering;

public static class SelectListExtensions
{
    public static IEnumerable<KeyValuePair<T, string>> WithBlankOption<T>(this IEnumerable<KeyValuePair<T, string>> items, string optionText)
    {
        yield return new KeyValuePair<T, string>(default(T), optionText);

        foreach (var item in items)
        {
            yield return item;
        }
    }

    public static IReadOnlyList<SelectListItem> ToSelectList<T>(this IEnumerable<KeyValuePair<T, string>> keyValuePairs, T selectedValue = default(T))
    {
        IEqualityComparer<T> comparer = EqualityComparer<T>.Default;
        return keyValuePairs.Select(
                pair => new SelectListItem() {
                    Value = GetKeySerialized(pair.Key),
                    Text = pair.Value,
                    Selected = comparer.Equals(selectedValue, pair.Key),
                }
            ).ToReadOnlyList();

        string GetKeySerialized(T key)
        {
            switch (key)
            {
                case ICanSerialize serializable:
                    return serializable.Serialize();
                default:
                    return key.ToString();
            }
        }
    }

    public static TagBuilder ToOptionTag(this SelectListItem item)
    {
        var tagBuilder = new TagBuilder("option");
        tagBuilder.MergeAttribute("value", item.Value);
        tagBuilder.InnerHtml.Append(item.Text);
        if (item.Selected)
        {
            tagBuilder.MergeAttribute("selected", "selected");
        }

        if (item.Disabled)
        {
            tagBuilder.MergeAttribute("disabled", "disabled");
        }

        return tagBuilder;
    }
}
