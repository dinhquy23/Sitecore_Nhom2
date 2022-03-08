using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using MockProject.Foundation.GlassMapper;
using MockProject.Feature.Sample.Constants;

namespace MockProject.Feature.Sample.Models.TemplateModels
{
    [SitecoreType(TemplateId = Templates.Navigation.TemplateId)]
    public class NavigationModel
    {
        [SitecoreField(Templates.Navigation.Fields.Items)]
        public virtual IEnumerable<HeaderNavigation> Items { get; set; }
    }
}