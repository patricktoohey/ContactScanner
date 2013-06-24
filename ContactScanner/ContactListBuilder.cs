namespace ContactScanner
{
    using System.Collections;

    public class ContactListBuilder
    {
        private Contacts contacts = new Contacts();

        public ContactListBuilder(ArrayList fullContactRegistry)
        {
            var boundsDetector = new ContactBoundsDetector();

            while(boundsDetector.NextBoundary(fullContactRegistry) > 0)
            {
                ArrayList contactDetails = new ArrayList();

                int boundary = boundsDetector.NextBoundary(fullContactRegistry);

                if (boundary > fullContactRegistry.Count)
                {
                    contacts.Add(new Contact(fullContactRegistry));
                    return;
                }

                for (int i=0; i<boundary; i++)
                {
                    contactDetails.Add(fullContactRegistry[i]);
                }

                contacts.Add(new Contact(contactDetails));

                fullContactRegistry.RemoveRange(0, boundary);
            }
        }

        public Contacts Contacts
        {
            get { return this.contacts; }
        }
    }
}
