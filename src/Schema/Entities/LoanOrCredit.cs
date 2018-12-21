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
    /// A financial product for the loaning of an amount of money under agreed terms and charges.
    /// <see cref="https://schema.org/LoanOrCredit"/>
    /// </summary>
    public class LoanOrCredit : IEntity
    {
        /// The amount of money.
        public Or<MonetaryAmount, double>? Amount { get; set; }

        /// The currency in which the monetary amount is expressed.
        /// 
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker symbol for cryptocurrencies e.g. "BTC"; well known names for Local Exchange Tradings Systems (LETS) and other currency types e.g. "Ithaca HOUR".
        public Or<string>? Currency { get; set; }

        /// The period of time after any due date that the borrower has to fulfil its obligations before a default (failure to pay) is deemed to have occurred.
        public Or<Duration>? GracePeriod { get; set; }

        /// A form of paying back money previously borrowed from a lender. Repayment usually takes the form of periodic payments that normally include part principal plus interest in each payment.
        public Or<RepaymentSpecification>? LoanRepaymentForm { get; set; }

        /// The duration of the loan or credit agreement.
        public Or<QuantitativeValue>? LoanTerm { get; set; }

        /// The type of a loan or credit.
        public Or<string, Uri>? LoanType { get; set; }

        /// The only way you get the money back in the event of default is the security. Recourse is where you still have the opportunity to go back to the borrower for the rest of the money.
        public Or<bool>? RecourseLoan { get; set; }

        /// Whether the terms for payment of interest can be renegotiated during the life of the loan.
        public Or<bool>? RenegotiableLoan { get; set; }

        /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
        public Or<string, Thing>? RequiredCollateral { get; set; }

        /// The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
        public Or<double, QuantitativeValue>? AnnualPercentageRate { get; set; }

        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        public Or<string, Uri>? FeesAndCommissionsSpecification { get; set; }

        /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
        public Or<double, QuantitativeValue>? InterestRate { get; set; }

        /// The overall rating, based on a collection of reviews or ratings, of the item.
        public Or<AggregateRating>? AggregateRating { get; set; }

        /// The geographic area where a service or offered item is provided. Supersedes serviceArea.
        public Or<AdministrativeArea, GeoShape, Place, string>? AreaServed { get; set; }

        /// An intended audience, i.e. a group for whom something was created. Supersedes serviceAudience.
        public Or<Audience>? Audience { get; set; }

        /// A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).
        public Or<ServiceChannel>? AvailableChannel { get; set; }

        /// An award won by or for this item. Supersedes awards.
        public Or<string>? Award { get; set; }

        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        public Or<Brand, Organization>? Brand { get; set; }

        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred. Supersedes bookingAgent.
        public Or<Organization, Person>? Broker { get; set; }

        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        public Or<PhysicalActivityCategory, string, Thing>? Category { get; set; }

        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        public Or<OfferCatalog>? HasOfferCatalog { get; set; }

        /// The hours during which this service or contact is available.
        public Or<OpeningHoursSpecification>? HoursAvailable { get; set; }

        /// A pointer to another, somehow related product (or multiple products).
        public Or<Product, Service>? IsRelatedTo { get; set; }

        /// A pointer to another, functionally similar product (or multiple products).
        public Or<Product, Service>? IsSimilarTo { get; set; }

        /// An associated logo.
        public Or<ImageObject, Uri>? Logo { get; set; }

        /// An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        public Or<Offer>? Offers { get; set; }

        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
        public Or<Organization, Person>? Provider { get; set; }

        /// Indicates the mobility of a provided service (e.g. 'static', 'dynamic').
        public Or<string>? ProviderMobility { get; set; }

        /// A review of the item. Supersedes reviews.
        public Or<Review>? Review { get; set; }

        /// The tangible thing generated by the service, e.g. a passport, permit, etc. Supersedes produces.
        public Or<Thing>? ServiceOutput { get; set; }

        /// The type of service being offered, e.g. veterans' benefits, emergency relief, etc.
        public Or<string>? ServiceType { get; set; }

        /// Human-readable terms of service documentation.
        public Or<string, Uri>? TermsOfService { get; set; }

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
