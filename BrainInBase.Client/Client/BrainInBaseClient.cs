using BrainInBase.Client.Extension;
using BrainInBase.Contracts.Models.Comprovante;
using BrainInBase.Contracts.Models.Emissor;
using BrainInBase.Contracts.Models.Registro;
using BrainInBase.Contracts.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BrainInBase.Client.Client
{
    public class BrainInBaseClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BrainInBaseClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        #region Usuarios
        public async Task<UsuarioResult> GetUsuarioAsync(string usuarioId)
        {
            return await _httpClientFactory.PostAsync<UsuarioResult>("api/usuario", usuarioId);
        }

        public async Task<UsuarioResult> FindUsuariosAsync(string termo)
        {
            return await _httpClientFactory.PostAsync<UsuarioResult>("api/usuario/termo", termo);
        }
        public async Task<UsuarioModel> PostUsuarioAsync(UsuarioModel model)
        {
            return await _httpClientFactory.PostAsync<UsuarioModel>("api/usuario/adicionar", model);
        }

        public async Task<UsuarioModel> UpdateUsuarioAsync(UsuarioModel model)
        {
            return await _httpClientFactory.PostAsync<UsuarioModel>("api/usuario/update", model);
        }
        #endregion

        #region Registros
        public async Task<RegistroResult> GetRegistroAsync(string registroId)
        {
            return await _httpClientFactory.PostAsync<RegistroResult>("api/registro", registroId);
        }
        public async Task<RegistroResult> FindRegistrosAsync(string termo)
        {
            return await _httpClientFactory.PostAsync<RegistroResult>("api/registro/termo", termo);
        }
        public async Task<RegistroModel> UpdateRegistroAsync(RegistroModel model)
        {
            return await _httpClientFactory.PostAsync<RegistroModel>("api/registro/update", model);
        }
        public async Task<RegistroModel> PostRegistroAsync(RegistroModel model)
        {
            return await _httpClientFactory.PostAsync<RegistroModel>("api/registro/adicionar", model);
        }
        #endregion

        #region Emissor
        public async Task<EmissorResult> GetEmissorAsync(string emissorId)
        {
            return await _httpClientFactory.PostAsync<EmissorResult>("api/emissor", emissorId);
        }
        public async Task<EmissorResult> FindEmissorAsync(string termo)
        {
            return await _httpClientFactory.PostAsync<EmissorResult>("api/emissor/termo", termo);
        }
        public async Task<EmissorModel> UpdateEmissorAsync(EmissorModel model)
        {
            return await _httpClientFactory.PostAsync<EmissorModel>("api/emissor/update", model);
        }
        public async Task<EmissorModel> PostEmissorAsync(EmissorModel model)
        {
            return await _httpClientFactory.PostAsync<EmissorModel>("api/emissor/adicionar", model);
        }
        #endregion

        #region Comprovante
        public async Task<ComprovanteResult> GetComprovanteAsync(string emissorId)
        {
            return await _httpClientFactory.PostAsync<ComprovanteResult>("api/comprovante", emissorId);
        }
        public async Task<ComprovanteResult> FindComprovanteAsync(string termo)
        {
            return await _httpClientFactory.PostAsync<ComprovanteResult>("api/comprovante/termo", termo);
        }
        public async Task<ComprovanteModel> UpdateComprovanteAsync(ComprovanteModel model)
        {
            return await _httpClientFactory.PostAsync<ComprovanteModel>("api/comprovante/update", model);
        }
        public async Task<ComprovanteModel> PostComprovanteAsync(ComprovanteModel model)
        {
            return await _httpClientFactory.PostAsync<ComprovanteModel>("api/comprovante/adicionar", model);
        }
        #endregion

    }
}
