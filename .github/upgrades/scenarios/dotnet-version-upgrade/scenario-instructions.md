# .NET Version Upgrade

## Preferences
- **Flow Mode**: Automatic
- **Target Framework**: net10.0

## Upgrade Options
**Source**: .github/upgrades/scenarios/dotnet-version-upgrade/upgrade-options.md

### Strategy
- Upgrade Strategy: All-at-Once

### Compatibility
- Unsupported API Handling: Fix Inline
- Windows Native APIs: Windows Compatibility Pack

## Strategy
**Selected**: All-At-Once
**Rationale**: Solução com apenas 1 projeto .NET Framework (net472), sem cadeia de dependências entre múltiplos projetos, favorecendo migração atômica.

### Execution Constraints
- Upgrade atômico em uma única passagem para o projeto
- Conversão para SDK-style deve ocorrer antes da troca de TFM
- Atualizar TFM, restaurar dependências e corrigir erros de compilação no mesmo fluxo
- Validação final obrigatória com build completo e testes
