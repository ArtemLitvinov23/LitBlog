﻿using LitBlog.BLL.ModelsDto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitBlog.BLL.Services
{
    public interface IAccountService
    {
        Task<AuthenticateResponseDto> AuthenticateAsync(AuthenticateRequestDto authRequest, string ipAddress);
        Task<AuthenticateResponseDto> RefreshTokenAsync(string token, string ipAddress);
        Task RevokeTokenAsync(string token, string ipAddress);
        Task RegisterAsync(AccountDto model, string origin);
        Task VerifyEmailAsync(string token);
        Task ForgotPasswordAsync(ForgotPasswordRequestDto model, string origin);
        Task ValidateResetTokenAsync(RevokeTokenRequestDto model);
        Task ResetPasswordAsync(ResetPasswordRequestDto model);
        Task<List<AccountResponseDto>> GetAllAccountsAsync();
        Task<AccountResponseDto> GetAccountByIdAsync(int accountId);
        Task<AccountResponseDto> GetAccountByEmailAsync(string accountEmail);
        Task<AccountResponseDto> CreateAccountAsync(AccountDto model);
        Task<AccountResponseDto> UpdateAccountAsync(int id, UpdateAccountDto model);
        Task<UsersResponseDto> GetUserByIdAsync(int id);
        Task<List<UsersResponseDto>> GetAllUsersAsync(int currentUserId);
        Task DeleteAccountAsync(int id);
    }
}