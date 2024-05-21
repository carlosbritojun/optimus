export abstract class ApiResult {

    //Verifica se o erro vem do ResultPatter
    private static isResultError(err: any) {
      return err.error.type == "A flow validation has occurred";
    }
    
    public static normalizeErrors(err: any) : string[] {
      
        let messages: string[] = [];

        if (this.isResultError(err))
        {
          messages.push(err.error.errors[0]);
        } else {
          console.log(err);
          //Aqui os erros vem do FluentValidation
          Object.keys(err.error.errors).forEach(key => {
              if (Array.isArray(err.error.errors[key])) {
                messages = messages.concat(err.error.errors[key]);
              }
          });
        }

        return messages;
    } 
}