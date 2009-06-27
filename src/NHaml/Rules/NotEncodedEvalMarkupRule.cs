
namespace NHaml.Rules
{
    public sealed class NotEncodedEvalMarkupRule : EvalMarkupRule
    {
        public override string Signifier
        {
            get { return "!="; }
        }

        public override BlockClosingAction Render( TemplateParser templateParser )
        {
            var builder = templateParser.TemplateClassBuilder;
            var inputLine = templateParser.CurrentInputLine;
            builder.AppendOutput( inputLine.Indent );

            builder.AppendCodeLine( inputLine.NormalizedText.Trim(), false );

            return EmptyClosingAction;
        }
    }
}