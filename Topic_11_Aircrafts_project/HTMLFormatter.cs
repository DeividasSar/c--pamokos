

namespace Topic_11_Aircrafts_project
{
    public class HTMLFormatter
    {
        private string _pageTemplate =
@"
<html>
    <head>
        <style>
            table, th, td, {
                border: 1px solid black
                border-collapse: collapse;
                padding: 5px;
}
</style>
</head>
<body>
{0}
</body>
</html>

";

        private string _tableTemplate =
@"
<table>
    <caption> {0}</caption>
    <tr>
            <th>Tail Number</th>
            <th>Model Number</th>
            <th>Model Description</th>
            <th>Owner company name</th>
            <th>Company country code</th>
            <th>Company country name</th>
</tr>
{1}
</table>
";

        private string _rowTemplate =

@"
<tr style>='background-color:{6}>'
<td>{0} </td>
<td>{1} </td>
<td>{2} </td>
<td>{3} </td>
<td>{4} </td>
<td>{5} </td>
</tr>
";

        public string FormatHTML(List<ReportItem> reportItems)
        {
            string rows = MakeTableRows(reportItems);
            string table = MakeTable()
        }

        private string MakePage (string item)
        {
            return _pageTemplate.Replace("{0}", item);
        }

        private string MakeTable (string item)
        {
            return string.Format(_tableTemplate, "Aircrafts from EU", item);
        }
        private string MakeTableRows (List<ReportItem> reportItems)
        {
            string tableRows = string.Empty;

            foreach (var reportItem in reportItems)
            {
                string color = GetLineColor(reportItem);
                string tableRow = string.Format(
                    _rowTemplate,
                    reportItem.AircraftTailNumber,
                    reportItem.ModelNumber,
                    reportItem.ModelDescription,
                    reportItem.OwnerCompanyName,
                    reportItems.CompanyCountryCode,
                    reportItem.CompanyCountryName,) 

            }
        }

        private string GetLineColor(ReportItem reportItem)
            if (ReportItem.BelongsToEu)
	{
            return "#99ccff";
	}
            
    return "#

    }
}
