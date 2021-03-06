id: cs.temp.dll
language: CSharp
name:
  Default: cs.temp.dll
qualifiedName:
  Default: cs.temp.dll
type: Assembly
modifiers: {}
items:
- id: BackendAcademico.Api.Controllers
  commentId: N:BackendAcademico.Api.Controllers
  language: CSharp
  name:
    CSharp: BackendAcademico.Api.Controllers
    VB: BackendAcademico.Api.Controllers
  nameWithType:
    CSharp: BackendAcademico.Api.Controllers
    VB: BackendAcademico.Api.Controllers
  qualifiedName:
    CSharp: BackendAcademico.Api.Controllers
    VB: BackendAcademico.Api.Controllers
  type: Namespace
  assemblies:
  - cs.temp.dll
  modifiers: {}
  items:
  - id: BackendAcademico.Api.Controllers.PreInscripcionController
    commentId: T:BackendAcademico.Api.Controllers.PreInscripcionController
    language: CSharp
    name:
      CSharp: PreInscripcionController
      VB: PreInscripcionController
    nameWithType:
      CSharp: PreInscripcionController
      VB: PreInscripcionController
    qualifiedName:
      CSharp: BackendAcademico.Api.Controllers.PreInscripcionController
      VB: BackendAcademico.Api.Controllers.PreInscripcionController
    type: Class
    assemblies:
    - cs.temp.dll
    namespace: BackendAcademico.Api.Controllers
    source:
      id: PreInscripcionController
      path: ''
      startLine: 12
    syntax:
      content:
        CSharp: 'public class PreInscripcionController : ControllerBase'
        VB: >-
          Public Class PreInscripcionController

              Inherits ControllerBase
    inheritance:
    - System.Object
    modifiers:
      CSharp:
      - public
      - class
      VB:
      - Public
      - Class
    items:
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.#ctor(IPreInscripcionService,ILogger{BackendAcademico.Api.Controllers.PreInscripcionController})
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.#ctor(IPreInscripcionService,ILogger{BackendAcademico.Api.Controllers.PreInscripcionController})
      language: CSharp
      name:
        CSharp: PreInscripcionController(IPreInscripcionService, ILogger<PreInscripcionController>)
        VB: PreInscripcionController(IPreInscripcionService, ILogger(Of PreInscripcionController))
      nameWithType:
        CSharp: PreInscripcionController.PreInscripcionController(IPreInscripcionService, ILogger<PreInscripcionController>)
        VB: PreInscripcionController.PreInscripcionController(IPreInscripcionService, ILogger(Of PreInscripcionController))
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.PreInscripcionController(IPreInscripcionService, ILogger<BackendAcademico.Api.Controllers.PreInscripcionController>)
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.PreInscripcionController(IPreInscripcionService, ILogger(Of BackendAcademico.Api.Controllers.PreInscripcionController))
      type: Constructor
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: .ctor
        path: ''
        startLine: 22
      syntax:
        content:
          CSharp: public PreInscripcionController(IPreInscripcionService preInscripcionService, ILogger<PreInscripcionController> logger)
          VB: Public Sub New(preInscripcionService As IPreInscripcionService, logger As ILogger(Of PreInscripcionController))
        parameters:
        - id: preInscripcionService
          type: IPreInscripcionService
        - id: logger
          type: ILogger{BackendAcademico.Api.Controllers.PreInscripcionController}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.#ctor*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetPeriodosAcademicos
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetPeriodosAcademicos
      language: CSharp
      name:
        CSharp: GetPeriodosAcademicos()
        VB: GetPeriodosAcademicos()
      nameWithType:
        CSharp: PreInscripcionController.GetPeriodosAcademicos()
        VB: PreInscripcionController.GetPeriodosAcademicos()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetPeriodosAcademicos()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetPeriodosAcademicos()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetPeriodosAcademicos
        path: ''
        startLine: 59
      summary: "\nCONSIDERACIONES: Devuele la lista de los peri??dos acad??micos habilitados para la pre-inscripci??n.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> +api/Academico/Preinscripcion/ObtenerPeriodosAcademicos \n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;id&quot;: &quot;gh8GevFlCVbXqMH9ij444a==&quot;,\n            &quot;codigo&quot;: &quot;V-2020&quot;\n        },\n        {\n            &quot;id&quot;: &quot;mWfzCjdGHwl9dsHxo5LjiQ==&quot;,\n            &quot;codigo&quot;: &quot;1-2021&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetPeriodosAcademicos()
          VB: Public Function GetPeriodosAcademicos As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetPeriodosAcademicos*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetCarreras
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetCarreras
      language: CSharp
      name:
        CSharp: GetCarreras()
        VB: GetCarreras()
      nameWithType:
        CSharp: PreInscripcionController.GetCarreras()
        VB: PreInscripcionController.GetCarreras()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetCarreras()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetCarreras()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetCarreras
        path: ''
        startLine: 110
      summary: "\nCONSIDERACIONES: Devuele la lista de las carreras habilitadas.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerCarreras \n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;id&quot;: &quot;fGZrfeQ6LvXdvVIGdsgHVw==&quot;,\n            &quot;nombre&quot;: &quot;EDUCACION (PSC)&quot;\n        },\n        {\n            &quot;id&quot;: &quot;zkzh3GevYyPDLn0YqFWZCA==&quot;,\n            &quot;nombre&quot;: &quot;LICENCIATURA EN EDUCACION SECUNDARIA&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetCarreras()
          VB: Public Function GetCarreras As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetCarreras*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetNacionalidades
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetNacionalidades
      language: CSharp
      name:
        CSharp: GetNacionalidades()
        VB: GetNacionalidades()
      nameWithType:
        CSharp: PreInscripcionController.GetNacionalidades()
        VB: PreInscripcionController.GetNacionalidades()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetNacionalidades()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetNacionalidades()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetNacionalidades
        path: ''
        startLine: 161
      summary: "\nCONSIDERACIONES: Devuele la lista de pa??ses para la nacionalidad.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerNacionalidades\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;id&quot;: &quot;ooo40MW8KdnMovKywZ6qzQ==&quot;,\n            &quot;nacionalidad&quot;: &quot;BOLIVIANA&quot;\n        },\n        {\n            &quot;id&quot;: &quot;4luIxuI/y0rmAbpjz84MwQ==&quot;,\n            &quot;nacionalidad&quot;: &quot;ALEMANA&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetNacionalidades()
          VB: Public Function GetNacionalidades As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetNacionalidades*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetSexos
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetSexos
      language: CSharp
      name:
        CSharp: GetSexos()
        VB: GetSexos()
      nameWithType:
        CSharp: PreInscripcionController.GetSexos()
        VB: PreInscripcionController.GetSexos()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetSexos()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetSexos()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetSexos
        path: ''
        startLine: 212
      summary: "\nCONSIDERACIONES: Devuelve la lista de sexos \n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerSexos\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;valor&quot;: &quot;ooo40MW8KdnMovKywZ6qzQ==&quot;,\n            &quot;descripcion&quot;: &quot;MASCULINO&quot;\n        },\n        {\n            &quot;valor&quot;: &quot;4mo9gjV/hDzYrnuqH0/IHA==&quot;,\n            &quot;descripcion&quot;: &quot;FEMENINO&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetSexos()
          VB: Public Function GetSexos As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetSexos*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetEstadosCiviles
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetEstadosCiviles
      language: CSharp
      name:
        CSharp: GetEstadosCiviles()
        VB: GetEstadosCiviles()
      nameWithType:
        CSharp: PreInscripcionController.GetEstadosCiviles()
        VB: PreInscripcionController.GetEstadosCiviles()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetEstadosCiviles()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetEstadosCiviles()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetEstadosCiviles
        path: ''
        startLine: 263
      summary: "\nCONSIDERACIONES: Devuele la lista de estado civil.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerEstadosCiviles\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;valor&quot;: &quot;slJUX1cOyzL3cdRvTXg3Wg==&quot;,\n            &quot;descripcion&quot;: &quot;DIVORCIADO&quot;\n        },\n        {\n            &quot;valor&quot;: &quot;9d5PCKdDxBLt4g%252bYtsTgyA==&quot;,\n            &quot;descripcion&quot;: &quot;VIUDO&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetEstadosCiviles()
          VB: Public Function GetEstadosCiviles As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetEstadosCiviles*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposDocumento
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposDocumento
      language: CSharp
      name:
        CSharp: GetTiposDocumento()
        VB: GetTiposDocumento()
      nameWithType:
        CSharp: PreInscripcionController.GetTiposDocumento()
        VB: PreInscripcionController.GetTiposDocumento()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposDocumento()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposDocumento()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetTiposDocumento
        path: ''
        startLine: 314
      summary: "\nCONSIDERACIONES: Devuele la lista de los tipos de documentos de identidad.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerTiposDocumento\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;valor&quot;: &quot;slJUX1cOyzL3cdRvTXg3Wg==&quot;,\n            &quot;descripcion&quot;: &quot;CERTIFICADO DE NACIMIENTO&quot;\n        },\n        {\n            &quot;valor&quot;: &quot;MhLc0N%252bjvAfuHLRo3NZY6g==&quot;,\n            &quot;descripcion&quot;: &quot;PASAPORTE&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetTiposDocumento()
          VB: Public Function GetTiposDocumento As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposDocumento*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTurnosColegio
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetTurnosColegio
      language: CSharp
      name:
        CSharp: GetTurnosColegio()
        VB: GetTurnosColegio()
      nameWithType:
        CSharp: PreInscripcionController.GetTurnosColegio()
        VB: PreInscripcionController.GetTurnosColegio()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetTurnosColegio()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetTurnosColegio()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetTurnosColegio
        path: ''
        startLine: 365
      summary: "\nCONSIDERACIONES: Devuele la lista de los turnos de Colegio.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerTurnosColegio\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;valor&quot;: &quot;ooo40MW8KdnMovKywZ6qzQ==&quot;,\n            &quot;descripcion&quot;: &quot;MA??ANA&quot;\n        },\n        {\n            &quot;valor&quot;: &quot;4mo9gjV/hDzYrnuqH0/IHA==&quot;,\n            &quot;descripcion&quot;: &quot;TARDE&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetTurnosColegio()
          VB: Public Function GetTurnosColegio As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetTurnosColegio*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTipoColegio
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetTipoColegio
      language: CSharp
      name:
        CSharp: GetTipoColegio()
        VB: GetTipoColegio()
      nameWithType:
        CSharp: PreInscripcionController.GetTipoColegio()
        VB: PreInscripcionController.GetTipoColegio()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetTipoColegio()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetTipoColegio()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetTipoColegio
        path: ''
        startLine: 416
      summary: "\nCONSIDERACIONES: Devuele la lista de los tipos de colegio.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerTiposColegio\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;valor&quot;: &quot;ooo40MW8KdnMovKywZ6qzQ==&quot;,\n            &quot;descripcion&quot;: &quot;PRIVADO&quot;\n        },\n        {\n            &quot;valor&quot;: &quot;4mo9gjV/hDzYrnuqH0/IHA==&quot;,\n            &quot;descripcion&quot;: &quot;ESTATAL&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetTipoColegio()
          VB: Public Function GetTipoColegio As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetTipoColegio*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetValoresViveCon
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetValoresViveCon
      language: CSharp
      name:
        CSharp: GetValoresViveCon()
        VB: GetValoresViveCon()
      nameWithType:
        CSharp: PreInscripcionController.GetValoresViveCon()
        VB: PreInscripcionController.GetValoresViveCon()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetValoresViveCon()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetValoresViveCon()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetValoresViveCon
        path: ''
        startLine: 467
      summary: "\nCONSIDERACIONES: Devuele la lista de de los valores de Vive Con.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerValoresViveCon\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;valor&quot;: &quot;ooo40MW8KdnMovKywZ6qzQ==&quot;,\n            &quot;descripcion&quot;: &quot;PADRE&quot;\n        },\n        {\n            &quot;valor&quot;: &quot;4mo9gjV/hDzYrnuqH0/IHA==&quot;,\n            &quot;descripcion&quot;: &quot;MADRE&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetValoresViveCon()
          VB: Public Function GetValoresViveCon As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetValoresViveCon*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposSangre
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposSangre
      language: CSharp
      name:
        CSharp: GetTiposSangre()
        VB: GetTiposSangre()
      nameWithType:
        CSharp: PreInscripcionController.GetTiposSangre()
        VB: PreInscripcionController.GetTiposSangre()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposSangre()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposSangre()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetTiposSangre
        path: ''
        startLine: 518
      summary: "\nCONSIDERACIONES: Devuele la lista de los tipos de sangre.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerEstadosCiviles\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;valor&quot;: &quot;ooo40MW8KdnMovKywZ6qzQ==&quot;,\n            &quot;descripcion&quot;: &quot;O RH+&quot;\n        },\n        {\n            &quot;valor&quot;: &quot;4mo9gjV/hDzYrnuqH0/IHA==&quot;,\n            &quot;descripcion&quot;: &quot;O RH-&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetTiposSangre()
          VB: Public Function GetTiposSangre As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposSangre*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosPorPais(System.Int32)
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosPorPais(System.Int32)
      language: CSharp
      name:
        CSharp: GetDepartamentosPorPais(Int32)
        VB: GetDepartamentosPorPais(Int32)
      nameWithType:
        CSharp: PreInscripcionController.GetDepartamentosPorPais(Int32)
        VB: PreInscripcionController.GetDepartamentosPorPais(Int32)
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosPorPais(System.Int32)
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosPorPais(System.Int32)
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetDepartamentosPorPais
        path: ''
        startLine: 567
      summary: "\nCONSIDERACIONES: Devuele los departamentos seg??n el ID del pa??s seleccionado. \n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: idPais (string)\n</p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerEstadosCiviles\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;id&quot;: &quot;znutLqucX0W/WixhwziIzg==&quot;,\n            &quot;nombre&quot;: &quot;LA PAZ&quot;\n        },\n        {\n            &quot;id&quot;: &quot;gPbRzH3wMyqs5Lq7T0jvJw==&quot;,\n            &quot;nombre&quot;: &quot;BENI&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetDepartamentosPorPais(int idPais)
          VB: Public Function GetDepartamentosPorPais(idPais As Integer) As Task(Of IActionResult)
        parameters:
        - id: idPais
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosPorPais*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosBolivia
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosBolivia
      language: CSharp
      name:
        CSharp: GetDepartamentosBolivia()
        VB: GetDepartamentosBolivia()
      nameWithType:
        CSharp: PreInscripcionController.GetDepartamentosBolivia()
        VB: PreInscripcionController.GetDepartamentosBolivia()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosBolivia()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosBolivia()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetDepartamentosBolivia
        path: ''
        startLine: 616
      summary: "\nCONSIDERACIONES: Devuelve la lista de los departamentos de Bolivia.\n<p>\nTIPO: GET\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerEstadosCiviles\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;id&quot;: &quot;c1YR0S9h845CZHS39vt8pA==&quot;,\n            &quot;nombre&quot;: &quot;SANTA CRUZ&quot;\n        },\n        {\n            &quot;id&quot;: &quot;8eteVicoi61wB1k4cAcJOg==&quot;,\n            &quot;nombre&quot;: &quot;TARIJA&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetDepartamentosBolivia()
          VB: Public Function GetDepartamentosBolivia As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosBolivia*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetProvinciasPorDepartamento(System.Int32)
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetProvinciasPorDepartamento(System.Int32)
      language: CSharp
      name:
        CSharp: GetProvinciasPorDepartamento(Int32)
        VB: GetProvinciasPorDepartamento(Int32)
      nameWithType:
        CSharp: PreInscripcionController.GetProvinciasPorDepartamento(Int32)
        VB: PreInscripcionController.GetProvinciasPorDepartamento(Int32)
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetProvinciasPorDepartamento(System.Int32)
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetProvinciasPorDepartamento(System.Int32)
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetProvinciasPorDepartamento
        path: ''
        startLine: 667
      summary: "\nCONSIDERACIONES: Devuele la lista de provincias seg??n el departamento seleccionado.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: idDepartamento (String)\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerEstadosCiviles\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;id&quot;: &quot;c1YR0S9h845CZHS39vt8pA==&quot;,\n            &quot;nombre&quot;: &quot;CERCADO&quot;\n        },\n        {\n            &quot;id&quot;: &quot;8eteVicoi61wB1k4cAcJOg==&quot;,\n            &quot;nombre&quot;: &quot;CARRASCO&quot;\n        }\n    ]\n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetProvinciasPorDepartamento(int idDepartamento)
          VB: Public Function GetProvinciasPorDepartamento(idDepartamento As Integer) As Task(Of IActionResult)
        parameters:
        - id: idDepartamento
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetProvinciasPorDepartamento*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetMunicipiosPorProvincia(System.Int32)
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetMunicipiosPorProvincia(System.Int32)
      language: CSharp
      name:
        CSharp: GetMunicipiosPorProvincia(Int32)
        VB: GetMunicipiosPorProvincia(Int32)
      nameWithType:
        CSharp: PreInscripcionController.GetMunicipiosPorProvincia(Int32)
        VB: PreInscripcionController.GetMunicipiosPorProvincia(Int32)
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetMunicipiosPorProvincia(System.Int32)
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetMunicipiosPorProvincia(System.Int32)
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetMunicipiosPorProvincia
        path: ''
        startLine: 718
      summary: "\nCONSIDERACIONES: Devuele la lista de los Municipios seg??n la Provincia seleccionada.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: idProvincia(String)\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerEstadosCiviles\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;id&quot;: &quot;c1YR0S9h845CZHS39vt8pA==&quot;,\n            &quot;nombre&quot;: &quot;LA PAZ&quot;\n        },\n        {\n            &quot;id&quot;: &quot;8eteVicoi61wB1k4cAcJOg==&quot;,\n            &quot;nombre&quot;: &quot;EL ALTO&quot;\n        }\n    ]\n} </code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetMunicipiosPorProvincia(int idProvincia)
          VB: Public Function GetMunicipiosPorProvincia(idProvincia As Integer) As Task(Of IActionResult)
        parameters:
        - id: idProvincia
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetMunicipiosPorProvincia*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetZonasPorMunicipio(System.Int32)
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetZonasPorMunicipio(System.Int32)
      language: CSharp
      name:
        CSharp: GetZonasPorMunicipio(Int32)
        VB: GetZonasPorMunicipio(Int32)
      nameWithType:
        CSharp: PreInscripcionController.GetZonasPorMunicipio(Int32)
        VB: PreInscripcionController.GetZonasPorMunicipio(Int32)
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetZonasPorMunicipio(System.Int32)
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetZonasPorMunicipio(System.Int32)
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetZonasPorMunicipio
        path: ''
        startLine: 769
      summary: "\nCONSIDERACIONES: Devuele la lista de las Zonas seg??n el Municipo seleccionado.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: idMunicipio(String)\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerEstadosCiviles \n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;id&quot;: &quot;c1YR0S9h845CZHS39vt8pA==&quot;,\n            &quot;nombre&quot;: &quot;CALA CALA&quot;\n        },\n        {\n            &quot;id&quot;: &quot;8eteVicoi61wB1k4cAcJOg==&quot;,\n            &quot;nombre&quot;: &quot;SACOBAMBA&quot;\n        }\n    ]\n} </code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetZonasPorMunicipio(int idMunicipio)
          VB: Public Function GetZonasPorMunicipio(idMunicipio As Integer) As Task(Of IActionResult)
        parameters:
        - id: idMunicipio
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetZonasPorMunicipio*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetColegiosPorProvincia(System.Int32)
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetColegiosPorProvincia(System.Int32)
      language: CSharp
      name:
        CSharp: GetColegiosPorProvincia(Int32)
        VB: GetColegiosPorProvincia(Int32)
      nameWithType:
        CSharp: PreInscripcionController.GetColegiosPorProvincia(Int32)
        VB: PreInscripcionController.GetColegiosPorProvincia(Int32)
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetColegiosPorProvincia(System.Int32)
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetColegiosPorProvincia(System.Int32)
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetColegiosPorProvincia
        path: ''
        startLine: 820
      summary: "\nCONSIDERACIONES: Devuele la lista de colegios a partir de un ID provincia.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: idProvincia (String)\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerEstadosCiviles\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;id&quot;: &quot;c1YR0S9h845CZHS39vt8pA==&quot;,\n            &quot;nombre&quot;: &quot;SAN CALIXTO&quot;\n        },\n        {\n            &quot;id&quot;: &quot;8eteVicoi61wB1k4cAcJOg==&quot;,\n            &quot;nombre&quot;: &quot;SAN IGNACIO&quot;\n        }\n    ]\n} </code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetColegiosPorProvincia(int idProvincia)
          VB: Public Function GetColegiosPorProvincia(idProvincia As Integer) As Task(Of IActionResult)
        parameters:
        - id: idProvincia
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetColegiosPorProvincia*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetProfesiones
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.GetProfesiones
      language: CSharp
      name:
        CSharp: GetProfesiones()
        VB: GetProfesiones()
      nameWithType:
        CSharp: PreInscripcionController.GetProfesiones()
        VB: PreInscripcionController.GetProfesiones()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.GetProfesiones()
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.GetProfesiones()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetProfesiones
        path: ''
        startLine: 871
      summary: "\nCONSIDERACIONES: Devuele la lista de profesiones de la lista de la Base de Datos.\n<p>\nTIPO: GET\n</p>\n<p>\nPAR??METROS: No requiere par??metros.\n</p>\n<p>\n<a href=\"http://localhost:8080/articles/intro.html\">URL BASE</a> api/Academico/Preinscripcion/ObtenerEstadosCiviles\n</p>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;data&quot;: [\n        {\n            &quot;id&quot;: &quot;Psoyk2MVU7IYwxyzBWsNSg==&quot;,\n            &quot;nombre&quot;: &quot;TECNOLOGIA DE ALIMENTOS&quot;\n        },\n        {\n            &quot;id&quot;: &quot;xKoQU/IoXiU4PbWmJoKWZA==&quot;,\n            &quot;nombre&quot;: &quot;DESARROLLO Y PLANIFICACION DE LA EDUCACION SUPERIOR&quot;\n        }\n    ]   \n}</code></pre>\n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> GetProfesiones()
          VB: Public Function GetProfesiones As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.GetProfesiones*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.PreInscripcionController.AddPreInscripcion(PreInscripcionQueryFilter)
      commentId: M:BackendAcademico.Api.Controllers.PreInscripcionController.AddPreInscripcion(PreInscripcionQueryFilter)
      language: CSharp
      name:
        CSharp: AddPreInscripcion(PreInscripcionQueryFilter)
        VB: AddPreInscripcion(PreInscripcionQueryFilter)
      nameWithType:
        CSharp: PreInscripcionController.AddPreInscripcion(PreInscripcionQueryFilter)
        VB: PreInscripcionController.AddPreInscripcion(PreInscripcionQueryFilter)
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.PreInscripcionController.AddPreInscripcion(PreInscripcionQueryFilter)
        VB: BackendAcademico.Api.Controllers.PreInscripcionController.AddPreInscripcion(PreInscripcionQueryFilter)
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: AddPreInscripcion
        path: ''
        startLine: 998
      summary: "\nCONSIDERACIONES: Guarda una nueva Pre-Inscripci??n.\n<p>\n<remarks>PROCESO:</remarks> pre-inscripci??n.\n</p>\n<returns>\n<img src=\"https://cdn.marketing123.123formbuilder.com/wp-content/uploads/2020/12/Formulario-de-Inscripcion-1095873.jpg\" alt=\"Mountain\" />     \n</returns>\n<p>\nTIPO: POST\n</p>\n<p>\nFormato del PayLoad de Pre-Inscripci??n:\n</p>\n<pre><code class=\"lang-cs\">{\n &quot;informacionGeneral&quot;: {\n  &quot;idCarrera&quot;: &quot;B65EJjJsnGXhytmZHqfQ==&quot;,\n  &quot;idPeriodoAcademico&quot;: &quot;gh8GelCVbXqMH9ij444w==&quot;,\n  &quot;fechaInscripcion&quot;: &quot;2019-08-28&quot;,\n  &quot;observacion&quot;: &quot;Sin observaciones&quot;\n},\n  &quot;datosPersonales&quot;: {\n  &quot;documentoIdentidad&quot;: &quot;8895578&quot;,\n  &quot;valorTipoDocumento&quot;: &quot;ooo4W8KdnMovKywZ6qzQ==&quot;,\n  &quot;idDepartamentoExpedido&quot;: &quot;ooo408KdnMovKywZ6qzQ==&quot;,\n  &quot;primerApellido&quot;: &quot;Rojas&quot;,\n  &quot;segundoApellido&quot;: &quot;Garcia&quot;,\n  &quot;tercerApellido&quot;: &quot;Guzman&quot;,\n  &quot;nombres&quot;: &quot;Carla&quot;,\n  &quot;fechaNacimiento&quot;: &quot;07/01/1999&quot;,\n  &quot;idPaisNacionalidad&quot;: &quot;ooo40MW8KdovKywZ6qzQ==&quot;,\n  &quot;idDepartamentoNacimiento&quot;: &quot;oooMW8KdnMovKywZ6qzQ==&quot;,\n  &quot;valorSexo&quot;: &quot;4mo9gjV/hDzYrnu/IHA==&quot;,\n  &quot;valorEstadoCivil&quot;: &quot;ooo40MKdnMovKywZ6qzQ==&quot;,\n  &quot;valorTipoSangre&quot;:  &quot;ooo40MKdnMovKywZ6qzQ==&quot;,\n  &quot;direccion&quot;: &quot;Av. America&quot;,\n  &quot;idZona&quot;: &quot;ngWP2wRvZTfy2aeq4xcw==&quot;,\n  &quot;telefonos&quot;: &quot;4245896&quot;,\n  &quot;celulares&quot;: &quot;70589630&quot;,\n  &quot;correoElectronico&quot;: &quot;carla@gmail.com&quot;,\n  &quot;trabaja&quot;: false,\n  &quot;lugarDeTrabajo&quot;: &quot;UMSS&quot;\n},\n  &quot;datosColegio&quot;: {\n  &quot;idColegio&quot;: &quot;6RGxgBKQ/HgJoq40MiHfw==&quot;,\n  &quot;idDepartamento&quot;:&quot;ooo408KdnMovKywZ6qzQ==&quot;,\n  &quot;idProvincia&quot;: &quot;ooo40MWdnMovKywZ6qzQ==&quot;,\n  &quot;valorTurno&quot;: &quot;ooo40MKdnMovKywZ6qzQ==&quot;,\n  &quot;valorTipoColegio&quot;: &quot;ooo40MW8KdnvKywZ6qzQ==&quot;,\n  &quot;anioEgreso&quot;: 2020\n},\n  &quot;datosPadre&quot;: {\n  &quot;primerApellido&quot;: &quot;Rojas&quot;,\n  &quot;segundoApellido&quot;: &quot;Garcia&quot;,\n  &quot;nombres&quot;: &quot;Ignacio&quot;,\n  &quot;direccion&quot;: &quot;Av. America&quot;,\n  &quot;idDepartamento&quot;: &quot;oooMW8KdnMovKywZ6qzQ==&quot;,\n  &quot;telefonos&quot;: &quot;78958963&quot;,\n  &quot;idProfesion&quot;: &quot;Psoyk2MVUIYwxyzBWsNSg==&quot;,\n  &quot;lugarDeTrabajo&quot;: &quot;UMSS&quot;\n},\n  &quot;datosMadre&quot;: {\n  &quot;primerApellido&quot;: &quot;Rojas&quot;,\n  &quot;segundoApellido&quot;: &quot;Garcia&quot;,\n  &quot;nombres&quot;: &quot;Luz&quot;,\n  &quot;direccion&quot;: &quot;Av. America&quot;,\n  &quot;idDepartamento&quot;: &quot;ooo40MW8KMovKywZ6qzQ==&quot;,\n  &quot;telefonos&quot;: &quot;78969637&quot;,\n  &quot;idProfesion&quot;: &quot;Psoyk2MVU7IYwxyzBNSg==&quot;,\n  &quot;lugarTrabajo&quot;: &quot;UMSS&quot;\n},\n  &quot;autorizaciones&quot;: [\n {\n  &quot;nombre&quot;: &quot;Luz Garcia&quot;,\n     &quot;correoElectronico&quot;: &quot;luzg@gmail.com&quot;\n   }\n ],\n &quot;hermanos&quot;: [\n {\n  &quot;nombre&quot;: &quot;Diego Garcia&quot;,\n  &quot;numeroDocumento&quot;: &quot;55286934&quot;\n }\n ],\n &quot;viveCon&quot;: {\n   &quot;valorViveCon&quot;: &quot;ooo40MW8nMovKywZ6qzQ==&quot;,\n   &quot;nombreTutor&quot;: &quot;Luz Garcia&quot;,\n   &quot;telefonos&quot;: &quot;4795896&quot;,\n   &quot;celulares&quot;: &quot;78986535&quot;\n  }\n}</code></pre>\n<p>\nRESULTADO:\n</p>\n<pre><code class=\"lang-cs\">{\n    &quot;response&quot;: {\n        &quot;process&quot;: &quot;Pre Inscripcion&quot;,\n        &quot;affectedRows&quot;: 1\n    }\n}</code></pre> \n"
      example: []
      syntax:
        content:
          CSharp: public Task<IActionResult> AddPreInscripcion(PreInscripcionQueryFilter preInscripcionQueryFilter)
          VB: Public Function AddPreInscripcion(preInscripcionQueryFilter As PreInscripcionQueryFilter) As Task(Of IActionResult)
        parameters:
        - id: preInscripcionQueryFilter
          type: PreInscripcionQueryFilter
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.PreInscripcionController.AddPreInscripcion*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
  - id: BackendAcademico.Api.Controllers.TestController
    commentId: T:BackendAcademico.Api.Controllers.TestController
    language: CSharp
    name:
      CSharp: TestController
      VB: TestController
    nameWithType:
      CSharp: TestController
      VB: TestController
    qualifiedName:
      CSharp: BackendAcademico.Api.Controllers.TestController
      VB: BackendAcademico.Api.Controllers.TestController
    type: Class
    assemblies:
    - cs.temp.dll
    namespace: BackendAcademico.Api.Controllers
    source:
      id: TestController
      path: ''
      startLine: 1037
    syntax:
      content:
        CSharp: 'public class TestController : ControllerBase'
        VB: >-
          Public Class TestController

              Inherits ControllerBase
    inheritance:
    - System.Object
    modifiers:
      CSharp:
      - public
      - class
      VB:
      - Public
      - Class
    items:
    - id: BackendAcademico.Api.Controllers.TestController.#ctor(ITestService,ILogger{BackendAcademico.Api.Controllers.TestController})
      commentId: M:BackendAcademico.Api.Controllers.TestController.#ctor(ITestService,ILogger{BackendAcademico.Api.Controllers.TestController})
      language: CSharp
      name:
        CSharp: TestController(ITestService, ILogger<TestController>)
        VB: TestController(ITestService, ILogger(Of TestController))
      nameWithType:
        CSharp: TestController.TestController(ITestService, ILogger<TestController>)
        VB: TestController.TestController(ITestService, ILogger(Of TestController))
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.TestController.TestController(ITestService, ILogger<BackendAcademico.Api.Controllers.TestController>)
        VB: BackendAcademico.Api.Controllers.TestController.TestController(ITestService, ILogger(Of BackendAcademico.Api.Controllers.TestController))
      type: Constructor
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: .ctor
        path: ''
        startLine: 1048
      syntax:
        content:
          CSharp: public TestController(ITestService testService, ILogger<TestController> logger)
          VB: Public Sub New(testService As ITestService, logger As ILogger(Of TestController))
        parameters:
        - id: testService
          type: ITestService
        - id: logger
          type: ILogger{BackendAcademico.Api.Controllers.TestController}
      overload: BackendAcademico.Api.Controllers.TestController.#ctor*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.TestController.GetDataBDTestAsync
      commentId: M:BackendAcademico.Api.Controllers.TestController.GetDataBDTestAsync
      language: CSharp
      name:
        CSharp: GetDataBDTestAsync()
        VB: GetDataBDTestAsync()
      nameWithType:
        CSharp: TestController.GetDataBDTestAsync()
        VB: TestController.GetDataBDTestAsync()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.TestController.GetDataBDTestAsync()
        VB: BackendAcademico.Api.Controllers.TestController.GetDataBDTestAsync()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetDataBDTestAsync
        path: ''
        startLine: 1056
      syntax:
        content:
          CSharp: public Task<IActionResult> GetDataBDTestAsync()
          VB: Public Function GetDataBDTestAsync As Task(Of IActionResult)
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.TestController.GetDataBDTestAsync*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.TestController.GetDataBDPaginationTestAsync(TestGetQueryFilter)
      commentId: M:BackendAcademico.Api.Controllers.TestController.GetDataBDPaginationTestAsync(TestGetQueryFilter)
      language: CSharp
      name:
        CSharp: GetDataBDPaginationTestAsync(TestGetQueryFilter)
        VB: GetDataBDPaginationTestAsync(TestGetQueryFilter)
      nameWithType:
        CSharp: TestController.GetDataBDPaginationTestAsync(TestGetQueryFilter)
        VB: TestController.GetDataBDPaginationTestAsync(TestGetQueryFilter)
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.TestController.GetDataBDPaginationTestAsync(TestGetQueryFilter)
        VB: BackendAcademico.Api.Controllers.TestController.GetDataBDPaginationTestAsync(TestGetQueryFilter)
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetDataBDPaginationTestAsync
        path: ''
        startLine: 1084
      syntax:
        content:
          CSharp: public Task<IActionResult> GetDataBDPaginationTestAsync(TestGetQueryFilter testQueryFilter)
          VB: Public Function GetDataBDPaginationTestAsync(testQueryFilter As TestGetQueryFilter) As Task(Of IActionResult)
        parameters:
        - id: testQueryFilter
          type: TestGetQueryFilter
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.TestController.GetDataBDPaginationTestAsync*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.TestController.GetConectivityApi
      commentId: M:BackendAcademico.Api.Controllers.TestController.GetConectivityApi
      language: CSharp
      name:
        CSharp: GetConectivityApi()
        VB: GetConectivityApi()
      nameWithType:
        CSharp: TestController.GetConectivityApi()
        VB: TestController.GetConectivityApi()
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.TestController.GetConectivityApi()
        VB: BackendAcademico.Api.Controllers.TestController.GetConectivityApi()
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: GetConectivityApi
        path: ''
        startLine: 1126
      syntax:
        content:
          CSharp: public IActionResult GetConectivityApi()
          VB: Public Function GetConectivityApi As IActionResult
        return:
          type: IActionResult
      overload: BackendAcademico.Api.Controllers.TestController.GetConectivityApi*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BackendAcademico.Api.Controllers.TestController.PostPersona(TestInsQueryFilter)
      commentId: M:BackendAcademico.Api.Controllers.TestController.PostPersona(TestInsQueryFilter)
      language: CSharp
      name:
        CSharp: PostPersona(TestInsQueryFilter)
        VB: PostPersona(TestInsQueryFilter)
      nameWithType:
        CSharp: TestController.PostPersona(TestInsQueryFilter)
        VB: TestController.PostPersona(TestInsQueryFilter)
      qualifiedName:
        CSharp: BackendAcademico.Api.Controllers.TestController.PostPersona(TestInsQueryFilter)
        VB: BackendAcademico.Api.Controllers.TestController.PostPersona(TestInsQueryFilter)
      type: Method
      assemblies:
      - cs.temp.dll
      namespace: BackendAcademico.Api.Controllers
      source:
        id: PostPersona
        path: ''
        startLine: 1145
      syntax:
        content:
          CSharp: public Task<IActionResult> PostPersona(TestInsQueryFilter testInsQueryFilter)
          VB: Public Function PostPersona(testInsQueryFilter As TestInsQueryFilter) As Task(Of IActionResult)
        parameters:
        - id: testInsQueryFilter
          type: TestInsQueryFilter
        return:
          type: System.Threading.Tasks.Task{IActionResult}
      overload: BackendAcademico.Api.Controllers.TestController.PostPersona*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
references:
  IPreInscripcionService:
    name:
      CSharp:
      - id: IPreInscripcionService
        name: IPreInscripcionService
        nameWithType: IPreInscripcionService
        qualifiedName: IPreInscripcionService
        isExternal: true
      VB:
      - id: IPreInscripcionService
        name: IPreInscripcionService
        nameWithType: IPreInscripcionService
        qualifiedName: IPreInscripcionService
        isExternal: true
    isDefinition: true
    commentId: '!:IPreInscripcionService'
  ILogger`1:
    name:
      CSharp:
      - id: ILogger`1
        name: ILogger
        nameWithType: ILogger
        qualifiedName: ILogger
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - name: ''
        nameWithType: ''
        qualifiedName: ''
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: ILogger`1
        name: ILogger
        nameWithType: ILogger
        qualifiedName: ILogger
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - name: ''
        nameWithType: ''
        qualifiedName: ''
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
  ILogger{BackendAcademico.Api.Controllers.PreInscripcionController}:
    name:
      CSharp:
      - id: ILogger`1
        name: ILogger
        nameWithType: ILogger
        qualifiedName: ILogger
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: BackendAcademico.Api.Controllers.PreInscripcionController
        name: PreInscripcionController
        nameWithType: PreInscripcionController
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: ILogger`1
        name: ILogger
        nameWithType: ILogger
        qualifiedName: ILogger
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: BackendAcademico.Api.Controllers.PreInscripcionController
        name: PreInscripcionController
        nameWithType: PreInscripcionController
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: ILogger`1
    commentId: '!:ILogger{BackendAcademico.Api.Controllers.PreInscripcionController}'
  BackendAcademico.Api.Controllers.PreInscripcionController.#ctor*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.#ctor*
        name: PreInscripcionController
        nameWithType: PreInscripcionController.PreInscripcionController
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.PreInscripcionController
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.#ctor*
        name: PreInscripcionController
        nameWithType: PreInscripcionController.PreInscripcionController
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.PreInscripcionController
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.#ctor
  System.Threading.Tasks.Task`1:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - name: TResult
        nameWithType: TResult
        qualifiedName: TResult
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - name: TResult
        nameWithType: TResult
        qualifiedName: TResult
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    commentId: T:System.Threading.Tasks.Task`1
  System.Threading.Tasks:
    name:
      CSharp:
      - name: System.Threading.Tasks
        nameWithType: System.Threading.Tasks
        qualifiedName: System.Threading.Tasks
        isExternal: true
      VB:
      - name: System.Threading.Tasks
        nameWithType: System.Threading.Tasks
        qualifiedName: System.Threading.Tasks
    isDefinition: true
    commentId: N:System.Threading.Tasks
  System.Threading.Tasks.Task{IActionResult}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: IActionResult
        name: IActionResult
        nameWithType: IActionResult
        qualifiedName: IActionResult
        isExternal: true
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: IActionResult
        name: IActionResult
        nameWithType: IActionResult
        qualifiedName: IActionResult
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{IActionResult}
  BackendAcademico.Api.Controllers.PreInscripcionController.GetPeriodosAcademicos*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetPeriodosAcademicos*
        name: GetPeriodosAcademicos
        nameWithType: PreInscripcionController.GetPeriodosAcademicos
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetPeriodosAcademicos
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetPeriodosAcademicos*
        name: GetPeriodosAcademicos
        nameWithType: PreInscripcionController.GetPeriodosAcademicos
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetPeriodosAcademicos
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetPeriodosAcademicos
  BackendAcademico.Api.Controllers.PreInscripcionController.GetCarreras*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetCarreras*
        name: GetCarreras
        nameWithType: PreInscripcionController.GetCarreras
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetCarreras
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetCarreras*
        name: GetCarreras
        nameWithType: PreInscripcionController.GetCarreras
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetCarreras
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetCarreras
  BackendAcademico.Api.Controllers.PreInscripcionController.GetNacionalidades*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetNacionalidades*
        name: GetNacionalidades
        nameWithType: PreInscripcionController.GetNacionalidades
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetNacionalidades
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetNacionalidades*
        name: GetNacionalidades
        nameWithType: PreInscripcionController.GetNacionalidades
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetNacionalidades
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetNacionalidades
  BackendAcademico.Api.Controllers.PreInscripcionController.GetSexos*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetSexos*
        name: GetSexos
        nameWithType: PreInscripcionController.GetSexos
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetSexos
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetSexos*
        name: GetSexos
        nameWithType: PreInscripcionController.GetSexos
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetSexos
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetSexos
  BackendAcademico.Api.Controllers.PreInscripcionController.GetEstadosCiviles*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetEstadosCiviles*
        name: GetEstadosCiviles
        nameWithType: PreInscripcionController.GetEstadosCiviles
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetEstadosCiviles
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetEstadosCiviles*
        name: GetEstadosCiviles
        nameWithType: PreInscripcionController.GetEstadosCiviles
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetEstadosCiviles
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetEstadosCiviles
  BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposDocumento*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposDocumento*
        name: GetTiposDocumento
        nameWithType: PreInscripcionController.GetTiposDocumento
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposDocumento
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposDocumento*
        name: GetTiposDocumento
        nameWithType: PreInscripcionController.GetTiposDocumento
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposDocumento
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposDocumento
  BackendAcademico.Api.Controllers.PreInscripcionController.GetTurnosColegio*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTurnosColegio*
        name: GetTurnosColegio
        nameWithType: PreInscripcionController.GetTurnosColegio
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetTurnosColegio
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTurnosColegio*
        name: GetTurnosColegio
        nameWithType: PreInscripcionController.GetTurnosColegio
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetTurnosColegio
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetTurnosColegio
  BackendAcademico.Api.Controllers.PreInscripcionController.GetTipoColegio*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTipoColegio*
        name: GetTipoColegio
        nameWithType: PreInscripcionController.GetTipoColegio
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetTipoColegio
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTipoColegio*
        name: GetTipoColegio
        nameWithType: PreInscripcionController.GetTipoColegio
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetTipoColegio
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetTipoColegio
  BackendAcademico.Api.Controllers.PreInscripcionController.GetValoresViveCon*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetValoresViveCon*
        name: GetValoresViveCon
        nameWithType: PreInscripcionController.GetValoresViveCon
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetValoresViveCon
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetValoresViveCon*
        name: GetValoresViveCon
        nameWithType: PreInscripcionController.GetValoresViveCon
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetValoresViveCon
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetValoresViveCon
  BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposSangre*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposSangre*
        name: GetTiposSangre
        nameWithType: PreInscripcionController.GetTiposSangre
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposSangre
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposSangre*
        name: GetTiposSangre
        nameWithType: PreInscripcionController.GetTiposSangre
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposSangre
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetTiposSangre
  System:
    name:
      CSharp:
      - name: System
        nameWithType: System
        qualifiedName: System
        isExternal: true
      VB:
      - name: System
        nameWithType: System
        qualifiedName: System
    isDefinition: true
    commentId: N:System
  System.Int32:
    name:
      CSharp:
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      VB:
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
    isDefinition: true
    parent: System
    commentId: T:System.Int32
  BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosPorPais*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosPorPais*
        name: GetDepartamentosPorPais
        nameWithType: PreInscripcionController.GetDepartamentosPorPais
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosPorPais
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosPorPais*
        name: GetDepartamentosPorPais
        nameWithType: PreInscripcionController.GetDepartamentosPorPais
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosPorPais
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosPorPais
  BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosBolivia*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosBolivia*
        name: GetDepartamentosBolivia
        nameWithType: PreInscripcionController.GetDepartamentosBolivia
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosBolivia
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosBolivia*
        name: GetDepartamentosBolivia
        nameWithType: PreInscripcionController.GetDepartamentosBolivia
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosBolivia
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetDepartamentosBolivia
  BackendAcademico.Api.Controllers.PreInscripcionController.GetProvinciasPorDepartamento*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetProvinciasPorDepartamento*
        name: GetProvinciasPorDepartamento
        nameWithType: PreInscripcionController.GetProvinciasPorDepartamento
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetProvinciasPorDepartamento
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetProvinciasPorDepartamento*
        name: GetProvinciasPorDepartamento
        nameWithType: PreInscripcionController.GetProvinciasPorDepartamento
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetProvinciasPorDepartamento
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetProvinciasPorDepartamento
  BackendAcademico.Api.Controllers.PreInscripcionController.GetMunicipiosPorProvincia*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetMunicipiosPorProvincia*
        name: GetMunicipiosPorProvincia
        nameWithType: PreInscripcionController.GetMunicipiosPorProvincia
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetMunicipiosPorProvincia
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetMunicipiosPorProvincia*
        name: GetMunicipiosPorProvincia
        nameWithType: PreInscripcionController.GetMunicipiosPorProvincia
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetMunicipiosPorProvincia
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetMunicipiosPorProvincia
  BackendAcademico.Api.Controllers.PreInscripcionController.GetZonasPorMunicipio*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetZonasPorMunicipio*
        name: GetZonasPorMunicipio
        nameWithType: PreInscripcionController.GetZonasPorMunicipio
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetZonasPorMunicipio
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetZonasPorMunicipio*
        name: GetZonasPorMunicipio
        nameWithType: PreInscripcionController.GetZonasPorMunicipio
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetZonasPorMunicipio
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetZonasPorMunicipio
  BackendAcademico.Api.Controllers.PreInscripcionController.GetColegiosPorProvincia*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetColegiosPorProvincia*
        name: GetColegiosPorProvincia
        nameWithType: PreInscripcionController.GetColegiosPorProvincia
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetColegiosPorProvincia
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetColegiosPorProvincia*
        name: GetColegiosPorProvincia
        nameWithType: PreInscripcionController.GetColegiosPorProvincia
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetColegiosPorProvincia
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetColegiosPorProvincia
  BackendAcademico.Api.Controllers.PreInscripcionController.GetProfesiones*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetProfesiones*
        name: GetProfesiones
        nameWithType: PreInscripcionController.GetProfesiones
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetProfesiones
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.GetProfesiones*
        name: GetProfesiones
        nameWithType: PreInscripcionController.GetProfesiones
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.GetProfesiones
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.GetProfesiones
  PreInscripcionQueryFilter:
    name:
      CSharp:
      - id: PreInscripcionQueryFilter
        name: PreInscripcionQueryFilter
        nameWithType: PreInscripcionQueryFilter
        qualifiedName: PreInscripcionQueryFilter
        isExternal: true
      VB:
      - id: PreInscripcionQueryFilter
        name: PreInscripcionQueryFilter
        nameWithType: PreInscripcionQueryFilter
        qualifiedName: PreInscripcionQueryFilter
        isExternal: true
    isDefinition: true
    commentId: '!:PreInscripcionQueryFilter'
  BackendAcademico.Api.Controllers.PreInscripcionController.AddPreInscripcion*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.AddPreInscripcion*
        name: AddPreInscripcion
        nameWithType: PreInscripcionController.AddPreInscripcion
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.AddPreInscripcion
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController.AddPreInscripcion*
        name: AddPreInscripcion
        nameWithType: PreInscripcionController.AddPreInscripcion
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController.AddPreInscripcion
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.PreInscripcionController.AddPreInscripcion
  BackendAcademico.Api.Controllers.PreInscripcionController:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController
        name: PreInscripcionController
        nameWithType: PreInscripcionController
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController
      VB:
      - id: BackendAcademico.Api.Controllers.PreInscripcionController
        name: PreInscripcionController
        nameWithType: PreInscripcionController
        qualifiedName: BackendAcademico.Api.Controllers.PreInscripcionController
    isDefinition: true
    commentId: T:BackendAcademico.Api.Controllers.PreInscripcionController
  ITestService:
    name:
      CSharp:
      - id: ITestService
        name: ITestService
        nameWithType: ITestService
        qualifiedName: ITestService
        isExternal: true
      VB:
      - id: ITestService
        name: ITestService
        nameWithType: ITestService
        qualifiedName: ITestService
        isExternal: true
    isDefinition: true
    commentId: '!:ITestService'
  ILogger{BackendAcademico.Api.Controllers.TestController}:
    name:
      CSharp:
      - id: ILogger`1
        name: ILogger
        nameWithType: ILogger
        qualifiedName: ILogger
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: BackendAcademico.Api.Controllers.TestController
        name: TestController
        nameWithType: TestController
        qualifiedName: BackendAcademico.Api.Controllers.TestController
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: ILogger`1
        name: ILogger
        nameWithType: ILogger
        qualifiedName: ILogger
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: BackendAcademico.Api.Controllers.TestController
        name: TestController
        nameWithType: TestController
        qualifiedName: BackendAcademico.Api.Controllers.TestController
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: ILogger`1
    commentId: '!:ILogger{BackendAcademico.Api.Controllers.TestController}'
  BackendAcademico.Api.Controllers.TestController.#ctor*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.TestController.#ctor*
        name: TestController
        nameWithType: TestController.TestController
        qualifiedName: BackendAcademico.Api.Controllers.TestController.TestController
      VB:
      - id: BackendAcademico.Api.Controllers.TestController.#ctor*
        name: TestController
        nameWithType: TestController.TestController
        qualifiedName: BackendAcademico.Api.Controllers.TestController.TestController
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.TestController.#ctor
  BackendAcademico.Api.Controllers.TestController.GetDataBDTestAsync*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.TestController.GetDataBDTestAsync*
        name: GetDataBDTestAsync
        nameWithType: TestController.GetDataBDTestAsync
        qualifiedName: BackendAcademico.Api.Controllers.TestController.GetDataBDTestAsync
      VB:
      - id: BackendAcademico.Api.Controllers.TestController.GetDataBDTestAsync*
        name: GetDataBDTestAsync
        nameWithType: TestController.GetDataBDTestAsync
        qualifiedName: BackendAcademico.Api.Controllers.TestController.GetDataBDTestAsync
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.TestController.GetDataBDTestAsync
  TestGetQueryFilter:
    name:
      CSharp:
      - id: TestGetQueryFilter
        name: TestGetQueryFilter
        nameWithType: TestGetQueryFilter
        qualifiedName: TestGetQueryFilter
        isExternal: true
      VB:
      - id: TestGetQueryFilter
        name: TestGetQueryFilter
        nameWithType: TestGetQueryFilter
        qualifiedName: TestGetQueryFilter
        isExternal: true
    isDefinition: true
    commentId: '!:TestGetQueryFilter'
  BackendAcademico.Api.Controllers.TestController.GetDataBDPaginationTestAsync*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.TestController.GetDataBDPaginationTestAsync*
        name: GetDataBDPaginationTestAsync
        nameWithType: TestController.GetDataBDPaginationTestAsync
        qualifiedName: BackendAcademico.Api.Controllers.TestController.GetDataBDPaginationTestAsync
      VB:
      - id: BackendAcademico.Api.Controllers.TestController.GetDataBDPaginationTestAsync*
        name: GetDataBDPaginationTestAsync
        nameWithType: TestController.GetDataBDPaginationTestAsync
        qualifiedName: BackendAcademico.Api.Controllers.TestController.GetDataBDPaginationTestAsync
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.TestController.GetDataBDPaginationTestAsync
  IActionResult:
    name:
      CSharp:
      - id: IActionResult
        name: IActionResult
        nameWithType: IActionResult
        qualifiedName: IActionResult
        isExternal: true
      VB:
      - id: IActionResult
        name: IActionResult
        nameWithType: IActionResult
        qualifiedName: IActionResult
        isExternal: true
    isDefinition: true
    commentId: '!:IActionResult'
  BackendAcademico.Api.Controllers.TestController.GetConectivityApi*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.TestController.GetConectivityApi*
        name: GetConectivityApi
        nameWithType: TestController.GetConectivityApi
        qualifiedName: BackendAcademico.Api.Controllers.TestController.GetConectivityApi
      VB:
      - id: BackendAcademico.Api.Controllers.TestController.GetConectivityApi*
        name: GetConectivityApi
        nameWithType: TestController.GetConectivityApi
        qualifiedName: BackendAcademico.Api.Controllers.TestController.GetConectivityApi
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.TestController.GetConectivityApi
  TestInsQueryFilter:
    name:
      CSharp:
      - id: TestInsQueryFilter
        name: TestInsQueryFilter
        nameWithType: TestInsQueryFilter
        qualifiedName: TestInsQueryFilter
        isExternal: true
      VB:
      - id: TestInsQueryFilter
        name: TestInsQueryFilter
        nameWithType: TestInsQueryFilter
        qualifiedName: TestInsQueryFilter
        isExternal: true
    isDefinition: true
    commentId: '!:TestInsQueryFilter'
  BackendAcademico.Api.Controllers.TestController.PostPersona*:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.TestController.PostPersona*
        name: PostPersona
        nameWithType: TestController.PostPersona
        qualifiedName: BackendAcademico.Api.Controllers.TestController.PostPersona
      VB:
      - id: BackendAcademico.Api.Controllers.TestController.PostPersona*
        name: PostPersona
        nameWithType: TestController.PostPersona
        qualifiedName: BackendAcademico.Api.Controllers.TestController.PostPersona
    isDefinition: true
    commentId: Overload:BackendAcademico.Api.Controllers.TestController.PostPersona
  BackendAcademico.Api.Controllers.TestController:
    name:
      CSharp:
      - id: BackendAcademico.Api.Controllers.TestController
        name: TestController
        nameWithType: TestController
        qualifiedName: BackendAcademico.Api.Controllers.TestController
      VB:
      - id: BackendAcademico.Api.Controllers.TestController
        name: TestController
        nameWithType: TestController
        qualifiedName: BackendAcademico.Api.Controllers.TestController
    isDefinition: true
    commentId: T:BackendAcademico.Api.Controllers.TestController
  BackendAcademico.Api.Controllers:
    name:
      CSharp:
      - name: BackendAcademico.Api.Controllers
        nameWithType: BackendAcademico.Api.Controllers
        qualifiedName: BackendAcademico.Api.Controllers
      VB:
      - name: BackendAcademico.Api.Controllers
        nameWithType: BackendAcademico.Api.Controllers
        qualifiedName: BackendAcademico.Api.Controllers
    isDefinition: true
    commentId: N:BackendAcademico.Api.Controllers
