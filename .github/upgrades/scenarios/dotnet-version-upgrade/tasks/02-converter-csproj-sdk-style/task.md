# 02-converter-csproj-sdk-style: Converter o projeto clássico para SDK-style

Converter `SistemaHotel.csproj` de formato clássico para SDK-style mantendo ainda o comportamento funcional esperado, separando mudança estrutural da mudança de framework. Essa separação é necessária porque os modos de falha são diferentes.

A conversão deve contemplar a migração de propriedades de projeto e referências relevantes para o formato moderno, preparando terreno para a troca de TFM.

**Done when**: O `SistemaHotel.csproj` estiver em formato SDK-style e o projeto compilar no framework atual de transição sem erros estruturais de projeto.

## Escopo da Tarefa

- Projeto afetado: `SistemaHotel\SistemaHotel.csproj` (único projeto da solução).
- Tipo: ClassicWinForms (`net472`, não SDK-style).
- Sinais do assessment para este task:
  - `Project.0001`: precisa converter para SDK-style.
  - `Project.0002`: troca de TFM (será tratada no task seguinte).
  - API issues altos (não entram neste task, apenas contexto).

## Notas de Pesquisa

- O arquivo atual usa formato legado (`ToolsVersion`, `Import Microsoft.CSharp.targets`).
- Há `.resx` e recursos WinForms (esperado em desktop), portanto validação pós-conversão deve usar build da solução/Visual Studio.
- Objetivo deste task é **somente** conversão estrutural do `.csproj`, sem trocar TFM nesta etapa.
