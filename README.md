IndexM
HEADER
header class="topo"
 nav class="barraNav"
 h2 class="esquerda"Olá h2
 h1 class="centro">Sorria+ h1
 a asp-controller="CadMedico" asp-action="LoginM"
class="btn-voltar direita" Sair a
 nav
header

1.header class="topo"
Cria um cabeçalho no site e a classe topo é usado para estilização
no CSS.

2.nav class="barraNav"
Define um tipo de barra de navegação. A classe barraNav é
utilizada no CSS para definir a aparência da barra.

3.h2 class="esquerda"Olá h2

4. h1 class="centro" Sorria+ h1

h1 e h2 são tamanhos de textos e class indica a sua posição em
relação ao elemento demarcado.

5.a asp-controller="CadMedico" asp-action="LoginM" class="btnvoltar direita"Sair a
Não é um link HTML comum, é um Tag Helper do ASP.NET Core.
O asp-controller="CadMedico" direciona para a controller
CadMedico. asp-action="LoginM" chama a action LoginM.
class="btn-voltar direita" é utilizada no CSS para estilizar o botão.

CARTÃO DO MÉDICO
div class="paiCarteirinha"
 div class="carteirinha"
 h3 CRM h3
  label Nome: DR. João Silva label
  label Número: 246810918 label
  label Especialidade: Odontologia label
   div
  div

1.div class="paiCarteirinha"
É um container externo para centralizar o cartão no layout.

2. div class="carteirinha">
Bloco que representa o cartão do profissional.

3. <h3>CRM</h3>
Funciona como um título de tamanho pré-definido

4. <label>Nome: DR. João Silva </label>
 <label>Número: 246810918 </label>
 <label>Especialidade: Odontologia </label>
Conteúdo Interno. Cada label representa um dado fixo do médico:
Nome, Número CRM e Especialidade.
CARDS DE CONSULTAS
<div class="container-cards">
<div class="card-consulta">
 <div class="info">
 <h3>Letícia Xavier</h3>
 <p><strong>Plano:</strong>Sorria+ Premium</p>
 <p><strong>Data:</strong> 15/12/2026</p>
 <p><strong>Hora:</strong> 10:00</p>
 <p><strong>Local:</strong> Sorria+ Pinheiros</p>
 </div>
 <div class="status">
 <button class="cancelar"> Cancelar</button>
 <button class="editar"> Confirmar</button>
 <label class="pendente">Pendente</label>
 </div>
</div>
  
1.<div class="container-cards">
Um container designado para agrupar todos os cards.

2. <div class="card-consulta">
É o bloco visual da consulta.

3. <div class="info">
Agrupa todos os dados dos pacientes: Nome, Tipo de Plano, Data,
Hora, Local de Consulta.

4. <div class="status">
É o bloco que contém as ações: Cancelar, Confirmar e a indicação
Pendente como label. As classes serão utilizadas como
identificação para a estilização no CSS.
SCRIPTS
<script src="~/js/IndexM.js"></script>
@section Scripts {
 <partial name="_ValidationScriptsPartial" />
}

1.<script src="~/js/IndexM.js"></script>
Importa um arquivo JavaScript localizado na pasta wwwroot/js.

2. @section Scripts
Essa é uma seção Razor utilizada em ASP.NET Core MVC. Serve
para enviar scripts adicionais para o layout principal (geralmente
_Layout.cshtml).

4. <partial name="_ValidationScriptsPartial" />
Importa o partial que contém scripts de validação padrão do
ASP.NET Core. É um padrão quando existe um formulário, mesmo
que aqui não esteja sendo usado diretamente.
Index
HEADER
<header class="topo">
 <nav class="barraNav">
 <h2 class="esquerda">Olá</h2>
 <h1 class="centro">Sorria+</h1>
 <a asp-controller="CadPaciente" asp-action="LoginP"
class="btn-voltar direita">Sair</a>
 </nav>
</header>

1.<header class="topo">
Cria um cabeçalho no site e a classe topo é usado para estilização
no CSS.

2.<nav class="barraNav">
Define um tipo de barra de navegação. A classe barraNav é
utilizada no CSS para definir a aparência da barra.

3.<h2 class="esquerda">Olá</h2>

4.<h1 class="centro">Sorria+</h1>
h1 e h2 são tamanhos de textos e class indica a sua posição em
relação ao elemento demarcado.

5.<a asp-controller="CadPaciente" asp-action="LoginP" class="btnvoltar direita">Sair</a>
Não é um link HTML comum, é um Tag Helper do ASP.NET Core.
O asp-controller=" CadPaciente " direciona para a controller
CadMedico. asp-action="LoginP" chama a action LoginP.
class="btn-voltar direita" é utilizada no CSS para estilizar o botão.
CARTEIRINHA DO PACIENTE
<div class="paiCarteirinha">
 <div class="carteirinha">
 <h3>Carteirinha Sorria+</h3>
 <label>Nome: Laura Valentini Xavier da Silva</label>
 <label>Número: 123456789 </label>
 <label>Plano: Sorria+ Plus </label>
 </div>
</div>

1.<div class="paiCarteirinha">
É um container externo para centralizar a carteirinha no layout.

2. <div class="carteirinha">
Bloco que representa a carteirinha do paciente.

3. <h3>CRM</h3>
Funciona como um título de tamanho pré-definido

4. <label>Nome: DR. João Silva </label>
 <label>Número: 246810918 </label>
 <label>Especialidade: Odontologia </label>
Conteúdo Interno. Cada label representa um dado fixo do paciente:
Nome, Número e Tipo de Plano.
MODAL PARA AGENDAMENTO
<div class="paiModal">
 <div class="modal" id="modal">
 <img src="~/img/btn-close.png" class="btn-close" id="btnclose"/>
   
1. <div class="paiModal">
Container geral do modal.

2. <div class="modal" id="modal">
A janela de agendamento que aparece por cima da tela. Classe
modal utilizada para a identificação na estilização do CSS. ID modal
utilizado pelo JS para abrir e fechar o modal.

3.<img src="~/img/btn-close.png" class="btn-close" id="btn-close"/>
Botão de fechar o modal com uma imagem inserida.
FORMULÁRIO DO MODAL
<div class="form-group">
<label for="especialidade">Escolha a especialidade:</label>
<select id="especialidade" class="form-control">
  
1.<div class="form-group">
Organiza os grupos de entrada

2.<label for="especialidade">Escolha a especialidade:</label>
Vincula o texto ao campo.

3. <select id="especialidade" class="form-control">
Lista de opções. Cada select representa uma lista de: Médicos,
Unidades e Horários Disponíveis. A classe form-control é a
identificação dos selects no CSS.
BOTÃO AGENDAR
<button type="submit" class="btn-agendar">Agendar
Consulta</button>

1.button type="submit"
Faz parte de um formulário onde o js pode capturar o clique. Classe
é para estilização.
CARDS DE CONSULTAS
div class="container-cards"
div class="card-consulta"
div class="info"
div class="status"
 button class="cancelar" Cancelar button
 button class="editar" Editar button
 label class="pendente" Pendente label
div
  
1.<iv class="container-cards"
Container que guarda todos os cards.

2. div class="card-consulta"
Bloco externo.

3. div class="info"
Container que guarda as informações da consulta: Nome do
Médico, Data, Hora e Local.

4.div class="status"
Container que armazena a coluna com botões e rótulo.

5.button class="cancelar" Cancelar button
Cria um botão que tem a função de cancelar. Classe para a
estilização no CSS.

6.button class="editar" Editar button 
Cria um botão que tem a função de confirmar. Classe para a
estilização no CSS.

7. label class="pendente"Pendente label
Cria um texto com o intuito de mostrar o status da consulta.
BOTÃO PARA ABRIR O MODAL
div class="popup-container"
 button class="popup">Agendar consulta button
div

1. <div class="popup-container">
Cria um container para armazenar o botão popup.

2. <button class="popup">Agendar consulta</button>
Cria um botão que tem a função de agendar a consulta. Classe para
a estilização no CSS.
SCRIPTS
<script src="~/js/IndexM.js"></script>
@section Scripts {
 <partial name="_ValidationScriptsPartial" />
}

1.<script src="~/js/IndexM.js"></script>
Importa um arquivo JavaScript localizado na pasta wwwroot/js.

2. @section Scripts
Essa é uma seção Razor utilizada em ASP.NET Core MVC. Serve
para enviar scripts adicionais para o layout principal (geralmente
_Layout.cshtml).

4. <partial name="_ValidationScriptsPartial" />
Importa o partial que contém scripts de validação padrão do
ASP.NET Core. É um padrão quando existe um formulário, mesmo
que aqui não esteja sendo usado diretamente.
_ViewImports.cshtml
@using Clinica
Importa o namespace principal do projeto chamado Clinica.Permite
que você use classes dentro desse namespace diretamente nas
suas views, sem precisar escrever: Clinica.AlgumaClasse
@using Clinica.Models
Importa o namespace onde ficam geralmente os modelos da
aplicação (classes como Paciente, Medico, Consulta, Plano, etc).
@addTagHelper *, Microsoft.AsoNetCore.Mvc.TagHelpers
Essa linha habilita os Tag Helpers do ASP.NET Core MVC nas suas
views.
ViewStart.cshtml
@{
 Layout = “_Layout”;
}
Essa instrução define qual layout a sua View irá usar.

CadastroP.cshtml
1.@model Clinica.Models.CadPac
Define o tipo de modelo que essa view recebe.

2.ViewData["Title"] = "Cadastrar";
Define o título da página, normalmente utilizado no _Layout.cshtml.

3.<div id="containerP" class="containerP">
Uma div que envolve todo o formulário de cadastro.

4.<form asp-action="CadastroP" asp-controller="CadPaciente"
method="post">
No POST, envia para o método:
CadPacienteController.CadastroP(CadPac model)

5.<select id="inputO" class="form-control">
Serve para redirecionar via JavaScript.

6. <label asp-for="Carteirinha"></label>
<input asp-for="Carteirinha" class="form-control">
<span asp-validation-for="Carteirinha" class="text-danger"></span>
Label recebe ao nome do atributo da Model, input vinculado à
propriedade Carteirinha, Validação em tempo real com data
annotations. Padrão válido para: CPF, Nome, DataNasci, Email,
Senha, Sexo, Telefone, IdPlano.

7. <select asp-for="Sexo">
 <option value="" disabled selected>Sexo:</option>
Se o valor vindo do Model for "F" ou "M", o Razor coloca selected
sozinho.

8. <a asp-action="LoginP" asp-controller="CadPaciente"
class="btntroca">
 Já tem conta? Faça Login
</a>
Tag Helper gera URL automaticamente:
/CadPaciente/LoginP

9.<script src="~/js/Paciente.js"></script>
Carrega JS específico da página.

10. @section Scripts {
 <partial name="_ValidationScriptsPartial" />
}
Carrega jQuery Validate + unobtrusive validation.
Usa as DataAnnotations do Model como: Required, EmailAddress e
StringLength. E exibe automaticamente nas <span asp-validationfor>.
LoginP.cshtml

1.@model Clinica.Models.CadPac
Define que esta View utiliza o modelo CadPac.

2. @{
 ViewData["Title"] = "Login";
}
Define o título da página, usado no layout _Layout.cshtml quando
renderiza <title> dinamicamente.

3. <img src="~/img/dente4bg.jpg" class="imgbg" />
Define uma imagem de fundo.

4. <div id="LoginP" class="LoginP">
Contêiner que centraliza e estiliza o formulário de login.
Usado também pelo JavaScript (Paciente.js).

5. <form asp-action="LoginP" asp-controller="CadPaciente"
method="post">
asp-action="LoginP" envia o POST para o método LoginP do
controller.
asp-controller="CadPaciente" envia para CadPacienteController.
method="post" envia com segurança (não aparece na URL).

6. h2 Realize seu Login h2
Título do Formulário.

7. select id="inputO" class="form-control"
 option selected disabled Selecionar tipo de acesso... option
 option selected Paciente option
 option value="/CadMedico/LoginM">Médico option
select
Este bloco cria um elemento <select> com opções que permitem ao
usuário escolher tipo de acesso: Paciente ou Médico.

8. <div class="form-group">
 label for="inputCPF"CPFlabel
 input asp-for="Cpf" class="form-control" id="inputCPF"
 span asp-validation-for="Cpf" class="text-danger" span
div
asp-for="Cpf" vincula ao modelo CadPac.Cpf.
asp-validation-for mensagens de erro automáticas
(DataAnnotations).

9. div class="form-group"
 label for="inputSenha" Senha label
 input asp-for="Senha" type="password" class="form-control"
id="inputSenha"
 span asp-validation-for="Senha" class="text-danger"span
div
Campo de senha, com proteção visual. Também validado pelas
DataAnnotations.

10. @if (ViewBag.Erro != null)
{
 div style="color:red" class="alert alertdanger" @ViewBag.Erro div
}
Se o controller colocou uma mensagem em ViewBag.Erro, ela é
mostrada ao usuário. Geralmente aparece quando: CPF incorreto,
Senha errada e Usuário não encontrado

11. button type="submit" class="btnCad" Acessa button
Envia o formulário para o método LoginP (POST). Classe btnCad
aplica estilo.

12. a asp-action="CadastroP" asp-controller="CadPaciente"
class="btntroca"
 Não tem conta ainda? Cadastre-se
a
Redireciona para o formulário de cadastro. Usa TagHelpers para
criar URL dinâmica.

13. <script src="~/js/Paciente.js"></script>
Carrega o arquivo JS do paciente. Geralmente controla:
redirecionamento do select de acesso, máscaras de CPF/Telefone,
animações

14. @section Scripts {
 <partial name="_ValidationScriptsPartial" />
}
Importa o partial do ASP.NET que ativa validação client-side:
jquery.validate, jquery.validate.unobtrusive.

CadMec.cs
1.public class CadMec
{
Define um modelo (Model) usado pelo MySQL.Data para
representar um médico cadastrado no sistema.

2.[Key]
[Required(ErrorMessage = "O CRM é obrigatório.")]
public int Crm { get; set; }
Explicação:
[Key] informa ao MySql.Data que Crm é a chave primária
(Primary Key) da tabela.
[Required] torna o preenchimento obrigatório.

3. [Required(ErrorMessage = "O nome é obrigatório.")]
public string? Nome { get; set; }
Explicação
[Required] impede cadastro sem nome.
Tipo string? permite nulo em teoria, mas o Required bloqueia no
ModelState.
Armazena o nome completo do médico.

4. [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
public string? Email { get; set; }
Explicação
[EmailAddress] → valida automaticamente se o e-mail tem formato
válido: @, domínio, extensão
Não possui [Required], então o médico pode ser cadastrado sem email.

5. [Required(ErrorMessage = "A senha é obrigatória.")]
[DataType(DataType.Password)]
public string? Senha { get; set; }
Explicação
[Required] obrigatório. [DataType(DataType.Password)] não altera o
banco, mas instrui o Razor a renderizar o campo como <input
type="password">. Armazena a senha (ideal é criptografar no
controller).

6. [Required(ErrorMessage = "O telefone é obrigatório.")]
[Phone(ErrorMessage = "Informe um número de telefone válido.")]
[RegularExpression(@"^\d{10,11}$", ErrorMessage = "O telefone
deve conter apenas números")]
public string? Telefone { get; set; }
Explicação
[Required] obrigatório. [Phone] valida formato de telefone.
[RegularExpression(@"^\d{10,11}$")] valida que: só pode conter
números, deve ter 10 ou 11 dígitos.

7. [Required(ErrorMessage = "A especialidade é obrigatória.")]
public string? Especialidade { get; set; }
Explicação
Campo obrigatório. Armazena a especialidade médica, ex:
Ortodontia, Endodontia, Odontopediatria, Clínica Geral.

CadPac.cs
1.public class CadPac
{
 [Key]
 [Required(ErrorMessage = "A carteirinha é obrigatória.")]
 [RegularExpression(@"^\d{9}$", ErrorMessage = "A carteirinha
deve conter apenas números (9 dígitos).")]
 public string? Carteirinha { get; set; }
Carteirinha
[Key] Esse campo será a chave primária no BD.
[Required] Obrigatório no cadastro.
[RegularExpression] Aceita apenas 9 dígitos numéricos.

2. [Required(ErrorMessage = "O CPF é obrigatório.")]
 [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve
conter apenas números (11 dígitos).")]
 public string? Cpf { get; set; }
CPF
Obrigatório. Apenas 11 dígitos numéricos. Também é string
(correto, para não perder zeros). Não valida CPF real, apenas o
formato.

3.[Required(ErrorMessage = "O nome é obrigatório.")]
 public string? Nome { get; set; }
Nome
Obrigatório.

4. [Required(ErrorMessage = "A data de nascimento é obrigatória")]
 [DataType(DataType.Date)]
 public DateTime? DataNasci { get; set; }
Data de Nascimento
Obrigatório. DateTime? permite vazio (mas o Required impede
isso). [DataType(DataType.Date)] melhora o input no navegador.

5. [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
 public string? Email { get; set; }
Email
Não é obrigatório. Mas se preencher, deve ter formato válido.

6. [Required(ErrorMessage = "A senha é obrigatória.")]
 [DataType(DataType.Password)]
 public string? Senha { get; set; }
Senha
Obrigatória. DataType.Password oculta caractere no formulário.

7.[Required(ErrorMessage = "O sexo é obrigatório")]
 public string? Sexo { get; set; }
Sexo
Obrigatório.

8.[Required(ErrorMessage = "O telefone é obrigatório.")]
 [Phone(ErrorMessage = "Informe um número de telefone
válido.")]
 [RegularExpression(@"^\d{10,11}$", ErrorMessage = "O telefone
deve conter apenas números")]
 public string? Telefone { get; set; }
Telefone
Obrigatório. Phone valida formato geral. Regex evita caracteres
especiais e exige 10 ou 11 dígitos.

9.[Required(ErrorMessage = "O Plano é obrigatório.")]
 public int IdPlano { get; set; }
 public Plano? PlanoPac { get; set; }
Plano (Relacionamento)
IdPlano é obrigatório. PlanoPac Propriedade de navegação MySql.Data
 (FK). Está configurado corretamente para um
relacionamento 1:N.

ErrorViewModel.cs
1. public string? RequestId { get; set; }
RequestId
Armazena o ID da requisição. Esse ID é útil para log, diagnóstico e
rastreamento. É definido pelo middleware de tratamento de erros.
Pode ser nulo, por isso string?.

2. public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
ShowRequestId
É uma propriedade somente leitura (não tem set). Retorna true
quando o RequestId não está vazio. Serve para a View decidir se
deve exibir o texto “Request ID: …”.

MedicoViewModel.cs
1.public CadMec Medico { get; set; } = new CadMec();
Essa propriedade contém os dados do médico que o usuário vai
cadastrar ou editar. O new CadMec() já inicializa a propriedade para
evitar null reference.

2. public List<Unidade> Unidades { get; set; } = new();
Essa é a lista de todas as unidades disponíveis (ex: clínicas, filiais,
consultórios). Ela é preenchida no controller e enviada para a View.
Na View, você vai usar essa lista para exibir: checkboxes,
dropdowns e selects múltiplos

3.public List<int> UnidadesSelecionadas { get; set; } = new
List<int>();
Guarda os IDs das unidades escolhidas pelo médico no formulário.
Serve para bind da View Controller. Normalmente é populado
quando o usuário envia o formulário POST.

Plano.cs
1.public int IdPlano { get; set; }
Chave primária do plano. É o identificador único no banco. [Key]
define como PK.

2.[Required] public string? Nome { get; set; }
Nome do plano. Exemplo: “Sorria+ Essencial” Required não pode
ficar em branco.

3.[Required] public decimal Valor { get; set; }
Preço do plano. O tipo decimal é correto para valores monetários.
Required sempre deve ter um valor definido.

4.[Required] public string? Tipo { get; set; }
Tipo do plano.
Foi usado para categorizar: Essencial, Plus e Premium
Required nunca pode ser nulo.

Unidade.cs
1.public int IdUnidade { get; set; }
Chave primária. Identifica unicamente cada unidade. [Key] indica ao
MySql que é a PK.

2.[Required] public string? NomeU { get; set; }
Nome da unidade. Exemplo: "Sorria+ Pinheiros" Required Não pode
ser nulo ou vazio.

3.[Required] public string? Endereco { get; set; }
Endereço completo da unidade: Rua, Número, Bairro e Cidade
Required Obrigatório.

CadMedico.cs
1.private readonly IConfiguration _configuration;
public CadMedico(IConfiguration configuration)
{
 _configuration = configuration;
}
O que é?
O controller recebe o IConfiguration automaticamente pelo
ASP.NET Core. Isso permite ler a connection string do
appsettings.json.
Para que serve?
Usado para se conectar no banco MySQL sem expor a string no
código.

2.[HttpGet]
public IActionResult LoginM()
{
 return View();
}
O que faz?
Apenas abre a página de Login do médico. Não envia dados para a
view.

3. [HttpPost]
public IActionResult LoginM(CadMec cadmec)
O que faz?
Recebe os dados enviados do formulário de login.

4.string? connectionString =
_configuration.GetConnectionString("DefaultConnection");
using var connection = new MySqlConnection(connectionString);
connection.Open();
Abre conexão no MySQL usando a connection string do
appsettings.json.

5. string sql = "SELECT * FROM tbMedico WHERE Crm = @Crm
AND Senha = @Senha";
Usa parâmetros protege contra SQL Injection.

6. MySqlCommand command = new MySqlCommand(sql,
connection);
command.Parameters.AddWithValue("@Crm", cadmec.Crm);
command.Parameters.AddWithValue("@Senha", cadmec.Senha);
using var reader = command.ExecuteReader();
Criando e executando o comando

7. if (reader.Read())
{
 return RedirectToAction("IndexM", "Home");
}
Se encontrou o médico, login OK

8.ViewBag.Erro = "CRM ou senha incorretos.";
return View(cadmec);
Se não encontrou, erro de login

9. [HttpGet]
public IActionResult CadastroM()
{
 var model = new MedicoViewModel();
 model.Medico = new CadMec();
 model.Unidades = BuscarUnidades();
 return View(model);
}
O que faz?
Cria um MedicoViewModel, que tem: dados do médico, lista de
unidades da clínica. Preenche Unidades consultando o banco
(função BuscarUnidades).
Para que serve?
Preencher o select múltiplo onde o médico escolhe onde atende.

10. private List<Unidade> BuscarUnidades()
O que faz?
Vai até o MySQL buscar todas as unidades cadastradas.

11.string sql = "SELECT IdUnidade, NomeU FROM tbUnidade";
Busca apenas o necessário.

12. while (reader.Read())
{
 lista.Add(
 new Unidade
 {
 IdUnidade = reader.GetInt32("IdUnidade"),
 NomeU = reader.GetString("NomeU")
 });
}
Retorna uma lista pronta para popular dropdowns.

13. [HttpPost]
public IActionResult CadastroM(MedicoViewModel vm)
if (!ModelState.IsValid)
{
 vm.Unidades = BuscarUnidades();
 return View(vm);
}
Se alguma data annotation falhar:Recarrega as unidades, retorna a
view com os erros.

14. using var transaction = connection.BeginTransaction();
Por quê?
Porque existem duas tabelas:
1. tbMedico

2. tbUnidade_Medico (relacionamento N:N)
Se uma falhar, ambas voltam atrás.

15. string sql = "INSERT INTO tbMedico ...";
MySqlCommand cmd = new MySqlCommand(sql, connection,
transaction);
Adiciona parâmetros de forma segura:
cmd.Parameters.AddWithValue("@Crm", vm.Medico.Crm);
...
cmd.ExecuteNonQuery();

16. string sql2 = @"INSERT INTO tbUnidade_Medico (IdUnidade,
Crm)
 VALUES (@IdUnidade, @Crm)";
O loop:
foreach (var idUni in vm.UnidadesSelecionadas.Distinct())
{
 cmd1.Parameters.Clear();
 cmd1.Parameters.AddWithValue("@IdUnidade", idUni);
 cmd1.Parameters.AddWithValue("@Crm", vm.Medico.Crm);
 cmd1.ExecuteNonQuery();
}
O que acontece aqui?
Para cada unidade marcada na view: cria um vínculo entre médico
e unidade, garante que não duplica registros (Distinct()).

17. transaction.Commit();
return RedirectToAction("IndexM", "Home");
Se der erro
catch (Exception ex)
{
 transaction.Rollback();
 vm.Unidades = BuscarUnidades();
 ModelState.AddModelError("", "Erro ao cadastrar médico: " +
ex.Message);
 return View(vm);
}

CadPaciente.cs
1. private readonly IConfiguration _configuration;
public CadPaciente(IConfiguration configuration)
{
 _configuration = configuration;
}
Recebe a configuração (appsettings.json) para pegar a connection
string. Padrão correto para ASP.NET Core.

2. [HttpGet]
public IActionResult LoginP()
{
 return View();
}
Apenas abre a tela de login.

3. [HttpPost]
public IActionResult LoginP(CadPac cadpac)
{
 string? connectionString = ...
 using var connection = new MySqlConnection(connectionString);
 connection.Open();
 string sql = "SELECT * FROM tbPaciente WHERE Cpf = @Cpf
AND Senha = @Senha";
 MySqlCommand command = new MySqlCommand(sql,
connection);
 command.Parameters.AddWithValue("@Cpf", cadpac.Cpf);
 command.Parameters.AddWithValue("@Senha", cadpac.Senha);
 using var reader = command.ExecuteReader();
O que ele faz?
Abre conexão com banco. Procura um paciente com CPF e senha
informados. Se encontrou faz login
Login Bem-Sucedido

4.if (reader.Read())
{
 return RedirectToAction("Index", "Home");
}
Login Inválido

5.ViewBag.Erro = "CPF ou senha incorretos.";
return View(cadpac);

6. [HttpGet]
public IActionResult CadastroP()
{
 return View();
}
Apenas abre a tela de cadastro.

7. [HttpPost]
public IActionResult CadastroP(CadPac cadpac)
{
 if (!ModelState.IsValid)
 {
 return View("CadastroP", cadpac);
 }
Valida data annotations. Se houver erro retorna com os erros
exibidos.

8.string sql = "INSERT INTO tbPaciente (Carteirinha, Cpf, Nome,
DataNasci, Email, Senha, Telefone, Sexo, IdPlano)
 VALUES(@Carteirinha, @Cpf, @Nome, @DataNasci,
@Email, @Senha, @Telefone, @Sexo, @IdPlano)";
Insere todos os dados corretamente. Usa parâmetros (evita SQL
Injection)

9. return RedirectToAction("Index", "Home");
Usuário preenche formulário. ModelState valida. Conecta ao
MySQL. Insere na tabela tbPaciente. Redireciona para Home
Home.cs
public IActionResult Index()
{
 return View();
}
Essa action normalmente representa a Home padrão ou o painel
inicial do paciente. Redirecionada no login do paciente:
return RedirectToAction("Index", "Home");
public IActionResult IndexM()
{
 return View();
}
Essa action representa a Home exclusiva do médico, outra tela,
outro dashboard. Redirecionada no login do médico:
return RedirectToAction("IndexM", "Home");

CadMedico.cs 
1. Injeção de Dependência
private readonly IConfiguration _configuration;
public CadMedico(IConfiguration configuration)
{
_configuration = configuration;
}
Recebe a configuração do appsettings.json para acessar a connection string. Estrutura padrão do
ASP.NET Core.

2. [HttpGet] LoginM
public IActionResult LoginM()
{
return View();
}
Apenas abre a tela de login do médico.

3. [HttpPost] LoginM
Abre conexão com o banco de dados usando MySQL e faz a verificação de CRM e Senha.

4. Consulta SQL do Login
string sql = "SELECT * FROM tbMedico WHERE Crm = @Crm AND Senha = @Senha";
Usa parâmetros para evitar SQL Injection.

5. Login Bem-Sucedido
if (reader.Read())
{
return RedirectToAction("IndexM", "Home");
}

6. Login Inválido
ViewBag.Erro = "CRM ou senha incorretos.";

7. [HttpGet] CadastroM
Carrega um MedicoViewModel vazio e a lista de unidades do banco.

8. BuscarUnidades
Consulta a tabela tbUnidade e retorna IdUnidade e NomeU.

9. [HttpPost] CadastroM
Valida ModelState, e caso inválido, retorna a página recarregando a lista de unidades.
10. Insert do Médico
INSERT INTO tbMedico (Crm, Nome, Telefone, Email, Senha, Especialidade)

11. Insert das Unidades Selecionadas
INSERT INTO tbUnidade_Medico (IdUnidade, Crm)

12. Commit
transaction.Commit();

13. Rollback
transaction.Rollback();
Resumo Final
LoginM GET abre a tela.
LoginM POST autentica o médico.
CadastroM GET prepara a tela com unidades.
CadastroM POST insere médico e unidades.
BuscarUnidades retorna unidade cadastradas.
