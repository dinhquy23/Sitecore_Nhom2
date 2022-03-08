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
    [SitecoreType(TemplateId = Templates.Header.TemplateId)]
    public class HeaderModel : GlassBase<Item>
    {
        //
        [SitecoreField(Templates.Header.Fields.Logo)]
        public virtual string Logo { get; set; }

        //
        [SitecoreField(Templates.Header.Fields.NameNavigation)]
        public virtual IEnumerable<HeaderNavigation> NameNavigation { get; set; }

        //
        [SitecoreField(Templates.Header.Fields.Date)]
        public virtual DateTime Date { get; set; }

        //
        [SitecoreField(Templates.Header.Fields.Link)]
        public virtual Glass.Mapper.Sc.Fields.Link Link { get; set; }
    }
}