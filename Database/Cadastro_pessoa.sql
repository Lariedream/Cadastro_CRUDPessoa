--
-- PostgreSQL database dump
--

-- Dumped from database version 16.3
-- Dumped by pg_dump version 16.3

-- Started on 2024-07-17 15:15:51

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 219 (class 1255 OID 16423)
-- Name: log_operacoes_trigger(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.log_operacoes_trigger() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    IF TG_OP = 'INSERT' THEN
        INSERT INTO log_operacoes (tipo_operacao, dados)
        VALUES ('INSERT', to_jsonb(NEW));
    ELSIF TG_OP = 'UPDATE' THEN
        INSERT INTO log_operacoes (tipo_operacao, dados)
        VALUES ('UPDATE', to_jsonb(NEW));
    ELSIF TG_OP = 'DELETE' THEN
        INSERT INTO log_operacoes (tipo_operacao, dados)
        VALUES ('DELETE', to_jsonb(OLD));
    END IF;
    RETURN NULL;
END;
$$;


ALTER FUNCTION public.log_operacoes_trigger() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 218 (class 1259 OID 16410)
-- Name: log_operacoes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.log_operacoes (
    id integer NOT NULL,
    data_hora timestamp without time zone DEFAULT CURRENT_TIMESTAMP NOT NULL,
    tipo_operacao character varying(10) NOT NULL,
    dados jsonb
);


ALTER TABLE public.log_operacoes OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16409)
-- Name: log_operacoes_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.log_operacoes_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.log_operacoes_id_seq OWNER TO postgres;

--
-- TOC entry 4805 (class 0 OID 0)
-- Dependencies: 217
-- Name: log_operacoes_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.log_operacoes_id_seq OWNED BY public.log_operacoes.id;


--
-- TOC entry 216 (class 1259 OID 16400)
-- Name: pessoa; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pessoa (
    id integer NOT NULL,
    nome character varying(50),
    cpf character varying(20),
    telefone bigint,
    CONSTRAINT chk_telefone_positive CHECK ((telefone > 0))
);


ALTER TABLE public.pessoa OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 16399)
-- Name: pessoa_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pessoa_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.pessoa_id_seq OWNER TO postgres;

--
-- TOC entry 4806 (class 0 OID 0)
-- Dependencies: 215
-- Name: pessoa_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pessoa_id_seq OWNED BY public.pessoa.id;


--
-- TOC entry 4641 (class 2604 OID 16413)
-- Name: log_operacoes id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.log_operacoes ALTER COLUMN id SET DEFAULT nextval('public.log_operacoes_id_seq'::regclass);


--
-- TOC entry 4640 (class 2604 OID 16403)
-- Name: pessoa id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pessoa ALTER COLUMN id SET DEFAULT nextval('public.pessoa_id_seq'::regclass);


--
-- TOC entry 4799 (class 0 OID 16410)
-- Dependencies: 218
-- Data for Name: log_operacoes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.log_operacoes (id, data_hora, tipo_operacao, dados) FROM stdin;
38	2024-07-17 14:16:11.62899	DELETE	{"id": 21, "cpf": "5154154515", "nome": "Teste", "telefone": 51515166}
\.


--
-- TOC entry 4797 (class 0 OID 16400)
-- Dependencies: 216
-- Data for Name: pessoa; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pessoa (id, nome, cpf, telefone) FROM stdin;
\.


--
-- TOC entry 4807 (class 0 OID 0)
-- Dependencies: 217
-- Name: log_operacoes_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.log_operacoes_id_seq', 38, true);


--
-- TOC entry 4808 (class 0 OID 0)
-- Dependencies: 215
-- Name: pessoa_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pessoa_id_seq', 21, true);


--
-- TOC entry 4649 (class 2606 OID 16416)
-- Name: log_operacoes log_operacoes_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.log_operacoes
    ADD CONSTRAINT log_operacoes_pkey PRIMARY KEY (id);


--
-- TOC entry 4645 (class 2606 OID 16405)
-- Name: pessoa pessoa_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pessoa
    ADD CONSTRAINT pessoa_pkey PRIMARY KEY (id);


--
-- TOC entry 4647 (class 2606 OID 16432)
-- Name: pessoa uq_telefone; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pessoa
    ADD CONSTRAINT uq_telefone UNIQUE (telefone);


--
-- TOC entry 4650 (class 2620 OID 16427)
-- Name: pessoa cadastro_after_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER cadastro_after_delete AFTER DELETE ON public.pessoa FOR EACH ROW EXECUTE FUNCTION public.log_operacoes_trigger();


--
-- TOC entry 4651 (class 2620 OID 16425)
-- Name: pessoa cadastro_after_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER cadastro_after_insert AFTER INSERT ON public.pessoa FOR EACH ROW EXECUTE FUNCTION public.log_operacoes_trigger();


--
-- TOC entry 4652 (class 2620 OID 16426)
-- Name: pessoa cadastro_after_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER cadastro_after_update AFTER UPDATE ON public.pessoa FOR EACH ROW EXECUTE FUNCTION public.log_operacoes_trigger();


-- Completed on 2024-07-17 15:15:51

--
-- PostgreSQL database dump complete
--

