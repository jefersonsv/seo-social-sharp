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
    /// A single item within a larger data feed.
    /// <see cref="https://schema.org/DataFeedItem"/>
    /// </summary>
    public class DataFeedItem : IEntity
    {
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        public Or<SuperStructs.Date, DateTime>? DateCreated { get; set; }

        /// The datetime the item was removed from the DataFeed.
        public Or<DateTime>? DateDeleted { get; set; }

        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        public Or<SuperStructs.Date, DateTime>? DateModified { get; set; }

        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        public Or<Thing>? Item { get; set; }

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
