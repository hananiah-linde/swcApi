using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Database.Entity.Threats;

public class Threat
{

    public string Identifier { get; set; }

    public string Referer { get; set; }

    public string Host { get; set; }

    public string UserAgent { get; set; }

    public string XForwardHost { get; set; }

    public string XForwardProto { get; set; }

    public string QueryString { get; set; }

    public string Protocol { get; set; }

    public Guid TypeId { get; set; }
    public Guid StatusId { get; set; }

    public virtual ThreatType ThreatType { get; set; }

    public virtual Status Status { get; set; }
