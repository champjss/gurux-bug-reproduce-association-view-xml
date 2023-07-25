using Gurux.DLMS.Objects;
using Gurux.DLMS.Secure;

//
// Test reading access3
//
void testReadingAssociationViewAccess3()
{
    var resourceFilePath = Path.Combine(Environment.CurrentDirectory, "resources/SampleAssociationViewAccess3.xml");

    var client = new GXDLMSSecureClient();
    client.Objects.AddRange(GXDLMSObjectCollection.Load(resourceFilePath));

    var targetObject = client.Objects.First();

    foreach (var attribute in targetObject.Attributes)
    {
        Console.WriteLine("Reading access3 for attribute index {0}: {1}", attribute.Index, attribute.Access3);
    }
    /**
    Result:
    (Please noted that the index was shifted.
    The first one with only "Read" access (8001) appears on index 2 instead of 3,
    and the last attribute was missing)

    Reading access3 for attribute index 1: Read, Write
    Reading access3 for attribute index 2: Read
    Reading access3 for attribute index 3: Read, Write
    Reading access3 for attribute index 4: Read, Write
    Reading access3 for attribute index 5: Read, Write
    Reading access3 for attribute index 6: Read, Write
    Reading access3 for attribute index 7: Read
    Reading access3 for attribute index 8: Read, Write
    */
}

//
// Test reading access1
//
void testReadingAssociationViewAccess1()
{

    var resourceFilePath = Path.Combine(Environment.CurrentDirectory, "resources/SampleAssociationViewAccess1.xml");

    var client = new GXDLMSSecureClient();
    client.Objects.AddRange(GXDLMSObjectCollection.Load(resourceFilePath));

    var targetObject = client.Objects.First();

    foreach (var attribute in targetObject.Attributes)
    {
        Console.WriteLine("Reading access1 for attribute index {0}: {1}", attribute.Index, attribute.Access);
    }
    /**
    Result:
    (The access1 can be readed correctly)

    Reading access1 for attribute index 1: Read
    Reading access1 for attribute index 2: ReadWrite
    Reading access1 for attribute index 3: Read
    Reading access1 for attribute index 4: Read
    Reading access1 for attribute index 5: NoAccess
    Reading access1 for attribute index 6: NoAccess
    Reading access1 for attribute index 7: NoAccess
    Reading access1 for attribute index 8: NoAccess
    Reading access1 for attribute index 9: Read
    */
}

testReadingAssociationViewAccess3();
testReadingAssociationViewAccess1();