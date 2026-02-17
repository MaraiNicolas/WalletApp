using System;
using System.Collections.Generic;
using System.Text;

namespace WalletApp.Domain.Core.Primitivos.Result
{
    public class Result
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public Error Error { get; }
        protected Result(bool isSuccess, Error error)
        {
            if(isSuccess && error != Error.None)
            {
                throw new InvalidOperationException();
            }
            if(isSuccess && error == Error.None)
            {
                throw new InvalidOperationException();
            }
            IsSuccess = isSuccess;
            Error= error;
        }

        public static Result Success() => new Result(true, Error.None);

        public static Result<TValue> Sucess<TValue>(TValue value) => new Result<TValue>(value, true, Error.None); 

        public static Result<TValue> Create<TValue>(TValue value, Error error) where TValue : class
            => value is null ? Failure<TValue>(error) : Sucess(value);

        public static Result Failure(Error error) => new Result(false, error);

        public static Result<TValue> Failure<TValue>(Error error) => new Result<TValue>(default!, false, error);

        public static Result FirstFailureOrSuccess(params Result[] results)
        {
            foreach(Result result in results)
            {
                if (result.IsFailure)
                {
                    return result;
                }
            }
            return Success();
        }
    }
    public class Result<TValue> : Result
    {
        private readonly TValue _value;
        protected internal Result(TValue value, bool isSuccess, Error error) : base(isSuccess, error)
        {
            _value = value;
        }

        
        public static implicit operator Result<TValue>(TValue value) => Sucess(value);

        public TValue Value => IsSuccess ? _value : throw new InvalidOperationException("El valor de un resultado erroneo no puede ser accedido.");
    }   
}
