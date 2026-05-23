
namespace Application1.Models
{
    public class Note
    {
        public required string Title { get;set; }
        public required string Description { get;set; }

        // this value tells whether description is expanded or not
        public Boolean IsExpanded { get; set; }

        // showing Short text if description exceeds the minimum length
        public string DescriptionText
        {
            get
            {
                if (IsExpanded)
                    return Description;

                if (string.IsNullOrWhiteSpace(Description))
                    return string.Empty;

                if (Description.Length <= 50)
                    return Description;

                return Description.Substring(0, 50) + "...";
            }
        }

        public string MoreLessText
        {
            get
            {
                if (Description.Length <= 50)
                    return string.Empty;

                return IsExpanded ? "Less" : "More";
            }
        }

    }
}
