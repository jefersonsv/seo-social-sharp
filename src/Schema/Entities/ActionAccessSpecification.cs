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
    /// A set of requirements that a must be fulfilled in order to perform an Action.
    /// <see cref="https://schema.org/ActionAccessSpecification"/>
    /// </summary>
    public class ActionAccessSpecification : IEntity
    {
        /// The end of the availability of the product or service included in the offer.
        public Or<DateTime>? AvailabilityEnds { get; set; }

        /// The beginning of the availability of the product or service included in the offer.
        public Or<DateTime>? AvailabilityStarts { get; set; }

        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        public Or<PhysicalActivityCategory, string, Thing>? Category { get; set; }

        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.
        /// 
        /// See also ineligibleRegion.
        public Or<GeoShape, Place, string>? EligibleRegion { get; set; }

        /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
        public Or<Offer>? ExpectsAcceptanceOf { get; set; }

        /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are true or false (note that an earlier version had 'yes', 'no').
        public Or<bool, MediaSubscription>? RequiresSubscription { get; set; }

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
