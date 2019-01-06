using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace RomarizIT.PostFromFacebookData.Localization
{
    public static class PostFromFacebookDataLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PostFromFacebookDataConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PostFromFacebookDataLocalizationConfigurer).GetAssembly(),
                        "RomarizIT.PostFromFacebookData.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
