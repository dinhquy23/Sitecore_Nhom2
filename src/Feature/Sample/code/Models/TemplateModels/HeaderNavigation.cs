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
    [SitecoreType(TemplateId = Templates.HeaderNavigation.TemplateId)]
    public class HeaderNavigation : GlassBase<Item>
    {
        [SitecoreField(Templates.HeaderNavigation.Fields.Title)]
        public virtual string Title { get; set; }


        [SitecoreField(Templates.HeaderNavigation.Fields.Link)]
        public virtual Glass.Mapper.Sc.Fields.Link Link { get; set; }
    }
}