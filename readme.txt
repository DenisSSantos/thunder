################################################################
Thunder
################################################################

Configura��o
================================================================
Ap�s a instala��o � necess�rio copiar as linhas abaixo e colar dentro do n� do xml ontem sua sessionfactory est� configurada.

<session-factory>
	...
	<listener type="pre-update" class="Thunder.Data.Pattern.CreatedAndUpdatedPropertyEventListener, Thunder"/>
	<listener type="pre-insert" class="Thunder.Data.Pattern.CreatedAndUpdatedPropertyEventListener, Thunder"/>
</session-factory>

