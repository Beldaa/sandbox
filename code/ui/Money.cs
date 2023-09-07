using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class Money : Panel
{
	public Label Label;

	public Money()
	{
		Label = Add.Label( "0$", "value" );
	}

	public override void Tick()
	{
		var player = Game.LocalPawn as SandboxPlayer;
		if ( player == null ) return;

		Label.Text = $"{player.Money.CeilToInt()}$";
	}
}
