# Upgrade Options — SistemaHotel.sln

Assessment: 1 projeto WinForms em net472, projeto clássico (não SDK-style), alto volume de APIs incompatíveis e uso forte de APIs Windows.

## Strategy

### Upgrade Strategy
Projeto único em .NET Framework, sem grafo de dependências entre múltiplos projetos; estratégia atômica é a mais adequada.

| Value | Description |
|-------|-------------|
| **All-at-Once** (selected) | Atualiza todo o projeto em uma única passagem, com validação ao final. |
| Bottom-Up | Atualiza por camadas de dependência (mais útil em soluções com 2+ projetos). |

## Compatibility

### Unsupported API Handling
A avaliação encontrou muitas APIs incompatíveis; mudanças simples e diretas devem ser resolvidas no próprio fluxo de migração.

| Value | Description |
|-------|-------------|
| **Fix Inline** (selected) | Corrige as APIs incompatíveis durante a própria task de upgrade, sem adiar via stubs. |
| Defer Complex Changes | Aplica stubs para mudanças complexas e cria subtasks de resolução posterior. |

### Windows Native APIs
O projeto usa amplamente Windows Forms/System.Drawing, então a compatibilidade Windows deve ser mantida durante a migração inicial.

| Value | Description |
|-------|-------------|
| **Windows Compatibility Pack** (selected) | Usa Microsoft.Windows.Compatibility para manter APIs Windows enquanto a migração evolui. |
| No Compatibility Pack | Força substituição imediata de APIs Windows por alternativas cross-platform. |
