using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SeoSocial.Schema;
using SeoSocial.Schema.Enumerations;
using SeoSocial.SuperStructs;

namespace SeoSocial.Schema.Entities
{
    /// <summary>
    /// A description of costs to the patient under a given network or formulary.
    /// <see cref="https://schema.org/HealthPlanCostSharingSpecification"/>
    /// </summary>
    public class HealthPlanCostSharingSpecification : IEntity
    {
        /// Whether the coinsurance applies before or after deductible, etc. TODO: Is this a closed set?
        public Or<string>? HealthPlanCoinsuranceOption { get; set; }

        /// Whether The rate of coinsurance expressed as a number between 0.0 and 1.0.
        public Or<double>? HealthPlanCoinsuranceRate { get; set; }

        /// Whether The copay amount.
        public Or<PriceSpecification>? HealthPlanCopay { get; set; }

        /// Whether the copay is before or after deductible, etc. TODO: Is this a closed set?
        public Or<string>? HealthPlanCopayOption { get; set; }

        /// The category or type of pharmacy associated with this cost sharing.
        public Or<string>? HealthPlanPharmacyCategory { get; set; }

        /// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.
        public Or<Uri>? AdditionalType { get; set; }

        /// An alias for the item.
        public Or<string>? AlternateName { get; set; }

        /// A description of the item.
        public Or<string>? Description { get; set; }

        /// A sub property of description. A short description of the item used to disambiguate from other, similar items. Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.
        public Or<string>? DisambiguatingDescription { get; set; }

        /// The identifier property represents any kind of identifier for any kind of Thing, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See background notes for more details.
        public Or<PropertyValue, string, Uri>? Identifier { get; set; }

        /// An image of the item. This can be a URL or a fully described ImageObject.
        public Or<ImageObject, Uri>? Image { get; set; }

        /// Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See background notes for details. Inverse property: mainEntity.
        public Or<CreativeWork, Uri>? MainEntityOfPage { get; set; }

        /// The name of the item.
        public Or<string>? Name { get; set; }

        /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
        public Or<Action>? PotentialAction { get; set; }

        /// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Wikidata entry, or official website.
        public Or<Uri>? SameAs { get; set; }

        /// A CreativeWork or Event about this Thing.. Inverse property: about.
        public Or<CreativeWork, Event>? SubjectOf { get; set; }

        /// URL of the item.
        public Or<Uri>? Url { get; set; }
    }
}
