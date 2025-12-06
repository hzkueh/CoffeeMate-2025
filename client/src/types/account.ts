export type Account = {
    id: string;
    displayName: string;
    email: string;
    token: string;
}

export type LoginCreds = {
    email: string;
    password: string;
}

export type RegisterCreds = {
    username: string;
    email: string;
    password: string;
}