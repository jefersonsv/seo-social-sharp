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
    /// A specific object or file containing a Legislation. Note that the same Legislation can be published in multiple files. For example, a digitally signed PDF, a plain PDF and an HTML version.
    /// <see cref="https://schema.org/LegislationObject"/>
    /// </summary>
    public class LegislationObject : IEntity
    {
        /// The legal value of this legislation file. The same legislation can be written in multiple files with different legal values. Typically a digitally signed PDF have a "stronger" legal value than the HTML file of the same act.
        public Or<LegalValueLevel>? LegislationLegalValue { get; set; }

        /// A NewsArticle associated with the Media Object.
        public Or<NewsArticle>? AssociatedArticle { get; set; }

        /// The bitrate of the media object.
        public Or<string>? Bitrate { get; set; }

        /// File size in (mega/kilo) bytes.
        public Or<string>? ContentSize { get; set; }

        /// Actual bytes of the media object, for example the image file or video file.
        public Or<Uri>? ContentUrl { get; set; }

        /// The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.
        public Or<Duration>? Duration { get; set; }

        /// A URL pointing to a player for a specific video. In general, this is the information in the src element of an embed tag and should not be the same as the content of the loc tag.
        public Or<Uri>? EmbedUrl { get; set; }

        /// The CreativeWork encoded by this media object.
        public Or<CreativeWork>? EncodesCreativeWork { get; set; }

        /// Media type typically expressed using a MIME format (see IANA site and MDN reference) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).
        /// 
        /// In cases where a CreativeWork has several media type representations, encoding can be used to indicate each MediaObject alongside particular encodingFormat information.
        /// 
        /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry. Supersedes fileFormat.
        public Or<string, Uri>? EncodingFormat { get; set; }

        /// The height of the item.
        public Or<Distance, QuantitativeValue>? Height { get; set; }

        /// Player type required—for example, Flash or Silverlight.
        public Or<string>? PlayerType { get; set; }

        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        public Or<Organization>? ProductionCompany { get; set; }

        /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in ISO 3166 format.
        public Or<Place>? RegionsAllowed { get; set; }

        /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are true or false (note that an earlier version had 'yes', 'no').
        public Or<bool, MediaSubscription>? RequiresSubscription { get; set; }

        /// Date when this media object was uploaded to this site.
        public Or<SuperStructs.Date>? UploadDate { get; set; }

        /// The width of the item.
        public Or<Distance, QuantitativeValue>? Width { get; set; }

        /// The subject matter of the content. Inverse property: subjectOf.
        public Or<Thing>? About { get; set; }

        /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.
        public Or<string>? AccessMode { get; set; }

        /// A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.
        public Or<string>? AccessModeSufficient { get; set; }

        /// Indicates that the resource is compatible with the referenced accessibility API (WebSchemas wiki lists possible values).
        public Or<string>? AccessibilityAPI { get; set; }

        /// Identifies input methods that are sufficient to fully control the described resource (WebSchemas wiki lists possible values).
        public Or<string>? AccessibilityControl { get; set; }

        /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (WebSchemas wiki lists possible values).
        public Or<string>? AccessibilityFeature { get; set; }

        /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (WebSchemas wiki lists possible values).
        public Or<string>? AccessibilityHazard { get; set; }

        /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."
        public Or<string>? AccessibilitySummary { get; set; }

        /// Specifies the Person that is legally accountable for the CreativeWork.
        public Or<Person>? AccountablePerson { get; set; }

        /// The overall rating, based on a collection of reviews or ratings, of the item.
        public Or<AggregateRating>? AggregateRating { get; set; }

        /// A secondary title of the CreativeWork.
        public Or<string>? AlternativeHeadline { get; set; }

        /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
        public Or<MediaObject>? AssociatedMedia { get; set; }

        /// An intended audience, i.e. a group for whom something was created. Supersedes serviceAudience.
        public Or<Audience>? Audience { get; set; }

        /// An embedded audio object.
        public Or<AudioObject>? Audio { get; set; }

        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        public Or<Organization, Person>? Author { get; set; }

        /// An award won by or for this item. Supersedes awards.
        public Or<string>? Award { get; set; }

        /// Fictional person connected with a creative work.
        public Or<Person>? Character { get; set; }

        /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        public Or<CreativeWork, string>? Citation { get; set; }

        /// Comments, typically from users.
        public Or<Comment>? Comment { get; set; }

        /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
        public Or<int>? CommentCount { get; set; }

        /// The location depicted or described in the content. For example, the location in a photograph or painting.
        public Or<Place>? ContentLocation { get; set; }

        /// Official rating of a piece of content—for example,'MPAA PG-13'.
        public Or<Rating, string>? ContentRating { get; set; }

        /// The specific time described by a creative work, for works (e.g. articles, video objects etc.) that emphasise a particular moment within an Event.
        public Or<DateTime>? ContentReferenceTime { get; set; }

        /// A secondary contributor to the CreativeWork or Event.
        public Or<Organization, Person>? Contributor { get; set; }

        /// The party holding the legal copyright to the CreativeWork.
        public Or<Organization, Person>? CopyrightHolder { get; set; }

        /// The year during which the claimed copyright for the CreativeWork was first asserted.
        public Or<double>? CopyrightYear { get; set; }

        /// Indicates a correction to a CreativeWork, either via a CorrectionComment, textually or in another document.
        public Or<CorrectionComment, string, Uri>? Correction { get; set; }

        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        public Or<Organization, Person>? Creator { get; set; }

        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        public Or<SuperStructs.Date, DateTime>? DateCreated { get; set; }

        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        public Or<SuperStructs.Date, DateTime>? DateModified { get; set; }

        /// Date of first broadcast/publication.
        public Or<SuperStructs.Date>? DatePublished { get; set; }

        /// A link to the page containing the comments of the CreativeWork.
        public Or<Uri>? DiscussionUrl { get; set; }

        /// Specifies the Person who edited the CreativeWork.
        public Or<Person>? Editor { get; set; }

        /// An alignment to an established educational framework.
        public Or<AlignmentObject>? EducationalAlignment { get; set; }

        /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
        public Or<string>? EducationalUse { get; set; }

        /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia. Supersedes encodings.
        public Or<MediaObject>? Encoding { get; set; }

        /// A creative work that this work is an example/instance/realization/derivation of. Inverse property: workExample.
        public Or<CreativeWork>? ExampleOfWork { get; set; }

        /// Date the content expires and is no longer useful or available. For example a VideoObject or NewsArticle whose availability or relevance is time-limited, or a ClaimReview fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.
        public Or<SuperStructs.Date>? Expires { get; set; }

        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        public Or<Organization, Person>? Funder { get; set; }

        /// Genre of the creative work, broadcast channel or group.
        public Or<string, Uri>? Genre { get; set; }

        /// Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense). Inverse property: isPartOf.
        public Or<CreativeWork, Trip>? HasPart { get; set; }

        /// Headline of the article.
        public Or<string>? Headline { get; set; }

        /// The language of the content or performance or used in an action. Please use one of the language codes from the IETF BCP 47 standard. See also availableLanguage. Supersedes language.
        public Or<Language, string>? InLanguage { get; set; }

        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used. Supersedes interactionCount.
        public Or<InteractionCounter>? InteractionStatistic { get; set; }

        /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        public Or<string>? InteractivityType { get; set; }

        /// A flag to signal that the item, event, or place is accessible for free. Supersedes free.
        public Or<bool>? IsAccessibleForFree { get; set; }

        /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html. Supersedes isBasedOnUrl.
        public Or<CreativeWork, Product, Uri>? IsBasedOn { get; set; }

        /// Indicates whether this content is family friendly.
        public Or<bool>? IsFamilyFriendly { get; set; }

        /// Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of. Inverse property: hasPart.
        public Or<CreativeWork, Trip>? IsPartOf { get; set; }

        /// Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
        public Or<string>? Keywords { get; set; }

        /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
        public Or<string>? LearningResourceType { get; set; }

        /// A license document that applies to this content, typically indicated by URL.
        public Or<CreativeWork, Uri>? License { get; set; }

        /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
        public Or<Place>? LocationCreated { get; set; }

        /// Indicates the primary entity described in some page or other CreativeWork. Inverse property: mainEntityOfPage.
        public Or<Thing>? MainEntity { get; set; }

        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        public Or<Product, string, Uri>? Material { get; set; }

        /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
        public Or<Thing>? Mentions { get; set; }

        /// An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        public Or<Offer>? Offers { get; set; }

        /// The position of an item in a series or sequence of items.
        public Or<int, string>? Position { get; set; }

        /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
        public Or<Organization, Person>? Producer { get; set; }

        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
        public Or<Organization, Person>? Provider { get; set; }

        /// A publication event associated with the item.
        public Or<PublicationEvent>? Publication { get; set; }

        /// The publisher of the creative work.
        public Or<Organization, Person>? Publisher { get; set; }

        /// The publishing division which published the comic.
        public Or<Organization>? PublisherImprint { get; set; }

        /// The publishingPrinciples property indicates (typically via URL) a document describing the editorial principles of an Organization (or individual e.g. a Person writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a CreativeWork (e.g. NewsArticle) the principles are those of the party primarily responsible for the creation of the CreativeWork.
        /// 
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a funder) can be expressed using schema.org terminology.
        public Or<CreativeWork, Uri>? PublishingPrinciples { get; set; }

        /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event. Inverse property: recordedIn.
        public Or<Event>? RecordedAt { get; set; }

        /// The place and time the release was issued, expressed as a PublicationEvent.
        public Or<PublicationEvent>? ReleasedEvent { get; set; }

        /// A review of the item. Supersedes reviews.
        public Or<Review>? Review { get; set; }

        /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
        public Or<string, Uri>? SchemaVersion { get; set; }

        /// Indicates the date on which the current structured data was generated / published. Typically used alongside sdPublisher
        public Or<SuperStructs.Date>? SdDatePublished { get; set; }

        /// A license document that applies to this structured data, typically indicated by URL.
        public Or<CreativeWork, Uri>? SdLicense { get; set; }

        /// Indicates the party responsible for generating and publishing the current structured data markup, typically in cases where the structured data is derived automatically from existing published content but published on a different site. For example, student projects and open data initiatives often re-publish existing content with more explicitly structured metadata. The
        /// sdPublisher property helps make such practices more explicit.
        public Or<Organization, Person>? SdPublisher { get; set; }

        /// The Organization on whose behalf the creator was working.
        public Or<Organization>? SourceOrganization { get; set; }

        /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
        ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
        ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York. Supersedes spatial.
        public Or<Place>? SpatialCoverage { get; set; }

        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        public Or<Organization, Person>? Sponsor { get; set; }

        /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in ISO 8601 time interval format. In
        ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
        ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".
        /// 
        /// Open-ended date ranges can be written with ".." in place of the end date. For example, "2015-11/.." indicates a range beginning in November 2015 and with no specified final date. This is tentative and might be updated in future when ISO 8601 is officially updated. Supersedes datasetTimeInterval, temporal.
        public Or<DateTime, string, Uri>? TemporalCoverage { get; set; }

        /// The textual content of this CreativeWork.
        public Or<string>? Text { get; set; }

        /// A thumbnail image relevant to the Thing.
        public Or<Uri>? ThumbnailUrl { get; set; }

        /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'P30M', 'P1H25M'.
        public Or<Duration>? TimeRequired { get; set; }

        /// The work that this work has been translated from. e.g. 物种起源 is a translationOf “On the Origin of Species” Inverse property: workTranslation.
        public Or<CreativeWork>? TranslationOfWork { get; set; }

        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        public Or<Organization, Person>? Translator { get; set; }

        /// The typical expected age range, e.g. '7-9', '11-'.
        public Or<string>? TypicalAgeRange { get; set; }

        /// The version of the CreativeWork embodied by a specified resource.
        public Or<double, string>? Version { get; set; }

        /// An embedded video object.
        public Or<VideoObject>? Video { get; set; }

        /// Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook. Inverse property: exampleOfWork.
        public Or<CreativeWork>? WorkExample { get; set; }

        /// A work that is a translation of the content of this work. e.g. 西遊記 has an English workTranslation “Journey to the West”,a German workTranslation “Monkeys Pilgerfahrt” and a Vietnamese  translation Tây du ký bình khảo. Inverse property: translationOfWork.
        public Or<CreativeWork>? WorkTranslation { get; set; }

        /// Indicates that this legislation (or part of a legislation) somehow transfers another legislation in a different legislative context. This is an informative link, and it has no legal value. For legally-binding links of transposition, use the legislationTransposes property. For example an informative consolidated law of a European Union's member state "applies" the consolidated version of the European Directive implemented in it.
        public Or<Legislation>? LegislationApplies { get; set; }

        /// Another legislation that this legislation changes. This encompasses the notions of amendment, replacement, correction, repeal, or other types of change. This may be a direct change (textual or non-textual amendment) or a consequential or indirect change. The property is to be used to express the existence of a change relationship between two acts rather than the existence of a consolidated version of the text that shows the result of the change. For consolidation relationships, use the legislationConsolidates property.
        public Or<Legislation>? LegislationChanges { get; set; }

        /// Indicates another legislation taken into account in this consolidated legislation (which is usually the product of an editorial process that revises the legislation). This property should be used multiple times to refer to both the original version or the previous consolidated version, and to the legislations making the change.
        public Or<Legislation>? LegislationConsolidates { get; set; }

        /// The date of adoption or signature of the legislation. This is the date at which the text is officially aknowledged to be a legislation, even though it might not even be published or in force.
        public Or<SuperStructs.Date>? LegislationDate { get; set; }

        /// The point-in-time at which the provided description of the legislation is valid (e.g. : when looking at the law on the 2016-04-07 (= dateVersion), I get the consolidation of 2015-04-12 of the "National Insurance Contributions Act 2015")
        public Or<SuperStructs.Date>? LegislationDateVersion { get; set; }

        /// An identifier for the legislation. This can be either a string-based identifier, like the CELEX at EU level or the NOR in France, or a web-based, URL/URI identifier, like an ELI (European Legislation Identifier) or an URN-Lex.
        public Or<string, Uri>? LegislationIdentifier { get; set; }

        /// The jurisdiction from which the legislation originates.
        public Or<AdministrativeArea, string>? LegislationJurisdiction { get; set; }

        /// Whether the legislation is currently in force, not in force, or partially in force.
        public Or<LegalForceStatus>? LegislationLegalForce { get; set; }

        /// The person or organization that originally passed or made the law : typically parliament (for primary legislation) or government (for secondary legislation). This indicates the "legal author" of the law, as opposed to its physical author.
        public Or<Organization, Person>? LegislationPassedBy { get; set; }

        /// An individual or organization that has some kind of responsibility for the legislation. Typically the ministry who is/was in charge of elaborating the legislation, or the adressee for potential questions about the legislation once it is published.
        public Or<Organization, Person>? LegislationResponsible { get; set; }

        /// Indicates that this legislation (or part of legislation) fulfills the objectives set by another legislation, by passing appropriate implementation measures. Typically, some legislations of European Union's member states or regions transpose European Directives. This indicates a legally binding link between the 2 legislations.
        public Or<Legislation>? LegislationTransposes { get; set; }

        /// The type of the legislation. Examples of values are "law", "act", "directive", "decree", "regulation", "statutory instrument", "loi organique", "règlement grand-ducal", etc., depending on the country.
        public Or<CategoryCode, string>? LegislationType { get; set; }

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
