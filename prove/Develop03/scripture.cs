using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Reference> references;

    public Scripture(List<Reference> references)
    {
        this.references = references;
    }

    public List<Reference> References
    {
        get { return references; }
    }
}